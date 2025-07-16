namespace CityFlow
{
    public partial class MainForm : Form
    {
        private readonly TransportSystem _transportSystem;

        public MainForm()
        {
            InitializeComponent();
            _transportSystem = new TransportSystem();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupTestData();
            InitializeDataBinding();
            UpdateDashboard();
        }

        private void SetupTestData()
        {
            _transportSystem.RegisterNewBus("AA1111XX", "101", "Богдан А092", 120, VechicleStatus.Available);
            _transportSystem.RegisterNewBus("AA2222XX", "102", "МАЗ 203", 215, VechicleStatus.InDepot);
            _transportSystem.RegisterNewBus("AA3333XX", "103", "MAN Lion's City", 56, VechicleStatus.Available);

            _transportSystem.HireDriver(Guid.NewGuid(), "Петро", "Петренко", new DateTime(1985, 5, 20));
            _transportSystem.HireDriver(Guid.NewGuid(), "Іван", "Іваненко", new DateTime(1990, 8, 15));
            var stop1 = new Stop(Guid.NewGuid(), "Контрактова площа", "до центру","Київ", 50.4646, 30.5160);
            var stop2 = new Stop(Guid.NewGuid(), "Поштова площа", "до центру", "Київ", 50.4590, 30.5265);
            var stop3 = new Stop(Guid.NewGuid(), "Майдан Незалежності", "до центру", "Київ", 50.4504, 30.5234);
            var stop4 = new Stop(Guid.NewGuid(), "Хрещатик", "до центру", "Київ", 50.4447, 30.5242);

            var route50 = new Route("50", "stop1", "stop4");
            route50.AddIntermadiateStop(stop2);
            route50.AddIntermadiateStop(stop3);

            // Додаємо їх в систему
            _transportSystem.Stops.Add(stop1);
            _transportSystem.Stops.Add(stop2);
            _transportSystem.Stops.Add(stop3);
            _transportSystem.Stops.Add(stop4);
            _transportSystem.Routes.Add(route50);

            // Призначимо один з автобусів на цей маршрут для тесту
            var busToAssign = _transportSystem.Buss.First();
            busToAssign.AssignedRoute = route50; // Потрібно додати public Route AssignedRoute { get; set; } в клас Bus
        }



        private void InitializeDataBinding()
        {
            busesDataGridView.DataSource = _transportSystem.Buss;
            driversDataGridView.DataSource = _transportSystem.Drivers;
            routesDataGridView.DataSource = _transportSystem.Routes;
        }

        private void UpdateDashboard()
        {
            driversOnRouteLabel.Text = $"Водіїв на лінії: {_transportSystem.Drivers.Count(d => d.Status == DriverStatus.OnRoute)}";
            busesOnRouteLabel.Text = $"Транспорту на лінії: {_transportSystem.Buss.Count(b => b.status == VehicleStatus.OnRoute)}";

            var availableDrivers = _transportSystem.Drivers.Where(d => d.Status == DriverStatus.Available).ToList();
            var availableBuses = _transportSystem.Buss.Where(b => b.status == VehicleStatus.Operational).ToList();
            var onRouteDrivers = _transportSystem.Drivers.Where(d => d.Status == DriverStatus.OnRoute).ToList();

            availableDriversComboBox.DataSource = availableDrivers;
            availableBusesComboBox.DataSource = availableBuses;
            onRouteDriversComboBox.DataSource = onRouteDrivers;

            mainTabControl.Invalidate();
        }

        private void assignToRouteButton_Click(object sender, EventArgs e)
        {
            var selectedDriver = availableDriversComboBox.SelectedItem as Driver;
            var selectedBus = availableBusesComboBox.SelectedItem as Bus;

            if (selectedDriver == null || selectedBus == null)
            {
                MessageBox.Show("Будь ласка, оберіть водія та автобус.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _transportSystem.AssignDriverToBusOnRoute(selectedDriver.EmployeeId);
                MessageBox.Show("Призначення успішне!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка призначення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void completeShiftButton_Click(object sender, EventArgs e)
        {
            var selectedDriver = onRouteDriversComboBox.SelectedItem as Driver;
            if (selectedDriver == null)
            {
                MessageBox.Show("Будь ласка, оберіть водія.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(mileageTextBox.Text, out double mileage) || mileage <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректний кінцевий пробіг.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                _transportSystem.CompleteShift(selectedDriver.EmployeeId, mileage);
                MessageBox.Show("Зміна успішно завершена!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mileageTextBox.Clear();
                UpdateDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завершення зміни: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void addBusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут буде відкриття форми для додавання автобуса", "В розробці");
        }

        private void monitorRouteButton_Click(object sender, EventArgs e)
        {
            var selectedRoute = routesDataGridView.CurrentRow?.DataBoundItem as Route;
            if (selectedRoute == null)
            {
                MessageBox.Show("Будь ласка, оберіть маршрут для моніторингу.", "Помилка");
                return;
            }

            var monitorForm = new RouteMonitorForm(selectedRoute, _transportSystem.Buss.ToList());
            monitorForm.Show();
            MessageBox.Show($"Відкриття моніторингу для маршруту №{selectedRoute.Number}", "В розробці");
        }
    }
}
