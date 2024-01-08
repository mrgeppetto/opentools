using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace opentools.ViewModels
{
    public partial class PowerFixViewModel : ViewModelBase
    {
        public PowerFixViewModel()
        {

        }

        [RelayCommand]
        private void StartFix()
        {
            MessageBox.Show("Starting Now");
        }

    }
}
