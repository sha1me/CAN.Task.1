using System.Windows;

namespace CAN.Task._1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}

