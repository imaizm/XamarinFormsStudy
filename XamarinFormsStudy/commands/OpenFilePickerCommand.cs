using System;
using System.Windows.Input;

namespace XamarinFormsStudy.Commands
{
    public class OpenFilePickerCommand : ICommand
    {
        private MainPageViewModel mainPageViewModel;

        public OpenFilePickerCommand(MainPageViewModel mainPageViewModel)
        {
            this.mainPageViewModel = mainPageViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            var file = await Plugin.FilePicker.CrossFilePicker.Current.PickFile();
            this.mainPageViewModel.BodyMessage = file.ToString();
        }
    }
}
