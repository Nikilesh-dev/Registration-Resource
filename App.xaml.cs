using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Registration2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ta-IN");

            //CultureInfo ci = new CultureInfo("ta-IN");
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentCulture = ci;
        }
    }
}
