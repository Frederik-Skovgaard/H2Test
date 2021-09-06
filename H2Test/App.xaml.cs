using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace H2Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindow winMain = new MainWindow();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            winMain.Show();
        }
    }
}
