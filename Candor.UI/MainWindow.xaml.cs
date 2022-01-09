using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Candor.Core.Mod;
using Serilog;
using Serilog.Core;

namespace Candor.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Entry point for the Application.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Call all logic that is required before window setup
            EntryPoint();
            InitializeComponent();
            Mod mod = new Mod();
        }

        /**
         * Sets up logging framework and any additional requirements before window is activated
         */
        void EntryPoint()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File("logs/myLog.log")
                .CreateLogger();
        }
    }
}