using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Serilog;
using Serilog.Core;
using Serilog.Sinks.File;
using System.Runtime.CompilerServices;
using opentools.Commands;
using System.Windows;
using System.Windows.Input;

namespace opentools.ViewModels
{
    public partial class AboutViewModel : ViewModelBase
    {

        public AboutViewModel()
        {
            Log.Information("Aboutview has been loaded");
        }


        // Add command to the end of the function to utilize ICommand
        [RelayCommand]
        private void MsgInfo()
        {
            MessageBox.Show("This is a test");
        }

        [RelayCommand]
        private void StartLog()
        {
            Log.Information("Logging has begun");
        }

    }
}
