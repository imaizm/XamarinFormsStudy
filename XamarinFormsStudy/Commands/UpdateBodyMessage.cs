using System;
using System.Windows.Input;
using XamarinFormsStudy;

namespace XamarinFormsStudy.Commands
{
    public class UpdateBodyMessage : ICommand
    {
        private MainPageViewModel mainPageViewModel;

        public UpdateBodyMessage(MainPageViewModel mainPageViewModel)
        {
            this.mainPageViewModel = mainPageViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(this.mainPageViewModel.InputMessage);
        }

        public void Execute(object parameter)
        {
            this.mainPageViewModel.BodyMessage = this.mainPageViewModel.InputMessage;
        }
    }
}
