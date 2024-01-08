using CommunityToolkit.Mvvm.ComponentModel;
using Serilog;
using Serilog.Core;
using Serilog.Sinks.File;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace opentools.ViewModels
{
    public class ViewModelBase : ObservableObject, INotifyPropertyChanged
    {
        public virtual new event PropertyChangedEventHandler? PropertyChanged;
        public Logger? logger;
        
        
        protected void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }

        public virtual Task LoadAsync() => Task.CompletedTask;
  

    }
}
