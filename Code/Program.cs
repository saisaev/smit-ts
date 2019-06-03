using System;
using System.Configuration;
using System.Windows;
using System.Windows.Threading;

namespace SmitDemo
{
    class App : Application
    {
        private const int INTERVAL_MSEC = 300;

        private const int STEPS_X = 200;

        private const int STEPS_Y = 20;

        public void Initialize() 
        {
            if (ConfigurationManager.GetSection("AppSettings") is AppSettings appSettings) {

                // read configuration from app.config
                var productLength = appSettings.ProductSettings.Length; 
                var productWidth = appSettings.ProductSettings.Width;

                var machineLength = appSettings.MachineSettings.Length;
                var machineWidth = appSettings.MachineSettings.Width;
                var machineCapacity = appSettings.MachineSettings.MaxCapacity;

                // define common product size
                ProductData.SetSize(productLength, productWidth);

                // compose a machine & main view & viewmodel 
                var machine = new MachineData(machineLength, machineWidth, machineCapacity);
                var machineViewModel = new MachineViewModel(machine);
                var machineView = new MachineView
                {
                    DataContext = machineViewModel
                };

                var mainView = new MainView
                {
                    DataContext = new MainViewModel(machineViewModel) {
                        StartPosX = 0,
                        StartPosY = machineWidth / 2
                    }
                };

                mainView.Show();

                // add-on to move products on the machine
                var movementX = machineLength / STEPS_X;
                var movementY = machineWidth / STEPS_Y;
                DispatcherTimer timer = new DispatcherTimer
                {
                    Interval = TimeSpan.FromMilliseconds(INTERVAL_MSEC)
                };

                var deviator = new Random();
                timer.Tick += (object sender, EventArgs e) =>
                {
                    // DispatcherTimer execute a callback in a parent (UI) thread
                    foreach (var product in machineViewModel.ProductViewModels) {
                        product.MachinePosX += movementX;
                        product.MachinePosY += movementY * (deviator.NextDouble()-0.5);
                    }
                };
                timer.Start();
            }
        }

        [STAThread]
        static void Main(string[] args) {

            App app = new App();
            app.Initialize();
            app.Run();
        }
    }
}
