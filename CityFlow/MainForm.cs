namespace CityFlow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            string number = routeNumberTextBox.Text;
            string start = startStopTextBox.Text;
            string end = endStopTextBox.Text;
            Route newRoute = new Route(number, start, end);
            routesListBox.Items.Add(newRoute.Number);
            routeNumberTextBox.Clear();
            startStopTextBox.Clear();
            endStopTextBox.Clear();

        }
    }
}
