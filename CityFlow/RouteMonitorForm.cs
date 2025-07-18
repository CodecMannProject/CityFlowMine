using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityFlow
{
    public partial class RouteMonitorForm : Form
    {
        private readonly Route _routeToMonitor;
        private readonly List<Bus> _busesOnRoute;
        private readonly List<PointF> _stopCoordinates; 

        private const int StopSize = 10;
        private const int BusSize = 14;

        public RouteMonitorForm(Route route, List<Bus> allBuses)
        {
            InitializeComponent();
            _routeToMonitor = route;
            _busesOnRoute = allBuses.Where(b => b.AssignedRoute == _routeToMonitor).ToList(); // Потрібно додати AssignedRoute в Bus
            _stopCoordinates = new List<PointF>();

            // Включаємо подвійну буферизацію для панелі, щоб уникнути мерехтіння
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            drawingPanel.Paint += DrawingPanel_Paint;
            this.Resize += (s, e) => { RecalculateCoordinates(); drawingPanel.Invalidate(); };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = $"Моніторинг маршруту №{_routeToMonitor.ToString()}";
            RecalculateCoordinates();
            InitializeBusPositions();
            animationTimer.Start();
        }

        // Ініціалізація початкових позицій автобусів
        private void InitializeBusPositions()
        {
            if (!_stopCoordinates.Any()) return;

            foreach (var bus in _busesOnRoute)
            {
                bus.NextStopIndex = 1; // Починають рух до другої зупинки
                bus.CurrentVisualX = _stopCoordinates[0].X;
                bus.CurrentVisualY = _stopCoordinates[0].Y;
            }
        }

     
        private void RecalculateCoordinates()
        {
            _stopCoordinates.Clear();
            var fullPath = _routeToMonitor.GetFullPath();
            if (fullPath.Count < 2) return;

            float minLat = fullPath.Min(s => (float)s.Latitude);
            float maxLat = fullPath.Max(s => (float)s.Latitude);
            float minLon = fullPath.Min(s => (float)s.Longitude);
            float maxLon = fullPath.Max(s => (float)s.Longitude);

            float latRange = maxLat - minLat;
            float lonRange = maxLon - minLon;

            // Залишаємо відступи
            int padding = 30;
            int panelWidth = drawingPanel.Width - 2 * padding;
            int panelHeight = drawingPanel.Height - 2 * padding;

            foreach (var stop in fullPath)
            {
                float x = padding + ((float)stop.Longitude - minLon) / lonRange * panelWidth;
                float y = padding + ((float)stop.Latitude - maxLat) / -latRange * panelHeight; // Y інвертований
                _stopCoordinates.Add(new PointF(x, y));
            }
        }

        // Головний метод малювання
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (_stopCoordinates.Count < 2) return;

            // 1. Малюємо лінії маршруту
            using (var routePen = new Pen(Color.Gray, 2))
            {
                for (int i = 0; i < _stopCoordinates.Count - 1; i++)
                {
                    g.DrawLine(routePen, _stopCoordinates[i], _stopCoordinates[i + 1]);
                }
            }

            // 2. Малюємо зупинки
            for (int i = 0; i < _stopCoordinates.Count; i++)
            {
                var stopPoint = _stopCoordinates[i];
                var rect = new RectangleF(stopPoint.X - StopSize / 2, stopPoint.Y - StopSize / 2, StopSize, StopSize);
                g.FillEllipse(Brushes.White, rect);
                g.DrawEllipse(Pens.Black, rect);

                // Підписуємо кінцеві зупинки
                if (i == 0 || i == _stopCoordinates.Count - 1)
                {
                    g.DrawString(_routeToMonitor.GetFullPath()[i].Name, this.Font, Brushes.Black, stopPoint.X + 10, stopPoint.Y);
                }
            }

            // 3. Малюємо автобуси
            foreach (var bus in _busesOnRoute)
            {
                var rect = new RectangleF(bus.CurrentVisualX - BusSize / 2, bus.CurrentVisualY - BusSize / 2, BusSize, BusSize);
                g.FillEllipse(Brushes.DarkRed, rect);
                g.DrawString(bus.ToString(), new Font(this.Font, FontStyle.Bold), Brushes.White, rect.X - 25, rect.Y - 20);
            }
        }

        // Тік таймера, що відповідає за анімацію
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            foreach (var bus in _busesOnRoute)
            {
                MoveBus(bus);
            }
            drawingPanel.Invalidate(); // Перемалювати панель
        }

        private void MoveBus(Bus bus)
        {
            if (bus.NextStopIndex >= _stopCoordinates.Count)
            {
                // Автобус досяг кінцевої, можна скинути його на початок
                bus.NextStopIndex = 1;
                bus.CurrentVisualX = _stopCoordinates[0].X;
                bus.CurrentVisualY = _stopCoordinates[0].Y;
                return;
            }

            PointF targetPoint = _stopCoordinates[bus.NextStopIndex];
            PointF currentPoint = new PointF(bus.CurrentVisualX, bus.CurrentVisualY);

            float dx = targetPoint.X - currentPoint.X;
            float dy = targetPoint.Y - currentPoint.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            // Якщо прибули на зупинку
            if (distance < 2)
            {
                bus.NextStopIndex++; // Наступна ціль - наступна зупинка
                return;
            }

            // Рухаємося в напрямку цілі
            float speed = 2.0f; // Швидкість руху в пікселях за кадр
            bus.CurrentVisualX += (dx / distance) * speed;
            bus.CurrentVisualY += (dy / distance) * speed;
        }
    }
}
