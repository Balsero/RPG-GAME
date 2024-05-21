using Engine.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Super_Adventure
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            string exceptionMessageText =
                $"An exception occurred: {e.Exception.Message}\r\n\r\nat: {e.Exception.StackTrace}";
            LoggingService.Log(e.Exception);
            // TODO: Create a Window to display the exception information.
            MessageBox.Show(exceptionMessageText, "Unhandled Exception", MessageBoxButton.OK);
        }
    }
}
