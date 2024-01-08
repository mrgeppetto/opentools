using CommunityToolkit.Mvvm.Input;
using opentools.DbCommand;
using opentools.Models;
using Serilog;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace opentools.ViewModels
{
    public partial class NotesViewModel : ViewModelBase
    {
        public ObservableCollection<OtNoteItem> OtNoteItems { get; set; }
        public override event PropertyChangedEventHandler? PropertyChanged;

        public OtNoteItem? SelectedItem { get; set; }
        private string? _inputOtNoteName;
        private string? _inputOtNoteDescription;

        public NotesViewModel()
        {
            OtNoteItems = new ObservableCollection<OtNoteItem>(OtNoteItemCommand.GetAllNoteItemDb());
        }

        // Added below event handling for clearing textboxes
        protected new virtual void OnPropertyChanged(string myProperty)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(myProperty));
        }

        public string? InputOtNoteName
        {
            get { return _inputOtNoteName; }
            set
            {
                if (_inputOtNoteName != value)
                {
                    _inputOtNoteName = value;
                    OnPropertyChanged(nameof(InputOtNoteName));
                }
            }
        }

        
        public string? InputOtNoteDescription
        {
            get { return _inputOtNoteDescription; }
            set
            {
                if (_inputOtNoteDescription != value)
                {
                    _inputOtNoteDescription = value;
                    OnPropertyChanged(nameof(InputOtNoteDescription));
                }
            }
        }

        [RelayCommand]
        private void NoteAdd()
        {
            if (InputOtNoteName != null)
            {
                if (InputOtNoteDescription == null)
                {
                    InputOtNoteDescription = "";
                }
                OtNoteItem otNoteItem = new OtNoteItem
                {
                    OtNoteName = InputOtNoteName,
                    OtNoteDescription = InputOtNoteDescription,
                    OtCreateTime = DateTime.Now,
                    OtIsActive = true,
                };

                OtNoteItemCommand.AddNoteItemDb(otNoteItem);
                OtNoteItems.Add(otNoteItem);
                Log.Information($"Note {InputOtNoteName} Added");
                InputOtNoteName = string.Empty;
                InputOtNoteDescription = string.Empty;
                
            }
            else
            {
                MessageBox.Show("Please verify you have a note name");
            }
        }

        [RelayCommand]
        private void NoteRemove()
        {
            if (SelectedItem != null)
            {
                OtNoteItemCommand.RmNoteItemDb(SelectedItem);
                OtNoteItems.Remove(SelectedItem);
                Log.Information($"Note {SelectedItem} removed");
            }
            else
            {
                MessageBox.Show("Please select a note to remove");
            }
        }

        [RelayCommand]
        private void BtnTest()
        {
            if (InputOtNoteName != null || InputOtNoteName == "")
            {
                MessageBox.Show(InputOtNoteName.Length.ToString());

            }
            else
            {
                MessageBox.Show("The input field is empty");
            }
            
        }






    }
}
