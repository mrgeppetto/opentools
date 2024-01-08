using opentools.Commands;
using Serilog;
using System.Threading.Tasks;

namespace opentools.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _selectedViewModel;
        public AppMainViewModel AppMainViewModel { get; }
        public PowerFixViewModel PowerFixViewModel { get; }
        public NotesViewModel NotesViewModel { get; }
        public AboutViewModel AboutViewModel { get; }
        public DelegateCommand SelectViewModelCommand { get; }
        public MainViewModel(AppMainViewModel appMainViewModel, 
                             PowerFixViewModel powerFixViewModel,
                             NotesViewModel notesViewModel,
                             AboutViewModel aboutViewModel)
        {
            AppMainViewModel = appMainViewModel;
            PowerFixViewModel = powerFixViewModel;
            NotesViewModel = notesViewModel;    
            AboutViewModel = aboutViewModel;
            SelectedViewModel = AppMainViewModel;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }

        public ViewModelBase? SelectedViewModel
        {

            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged();
            }

        }

        public async override Task LoadAsync()
        {

            if (SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }

        } 

        public async void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
            await LoadAsync();
        }


    }
}
