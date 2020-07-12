using System;
using System.Windows.Input;

namespace XamarinFormsStudy.Commands
{
    public class OpenFilePickerCommand : ICommand
    {
        public OpenFilePickerCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
