using System;
using System.Windows.Input;
using XamarinFormsStudy.Views;
using XamarinFormsStudy.Commands;

namespace XamarinFormsStudy
{
    public class MainPageViewModel : ViewModelBase
    {
        private string bodyMessage = "Initial body message";
        public string BodyMessage
        {
            get { return bodyMessage; }
            set
            {
                this.bodyMessage = value;
                this.OnPropertyChanged(nameof(BodyMessage));
            }
        }

        private string inputMessage;
        public string InputMessage
        {
            get { return inputMessage; }
            set
            {
                this.inputMessage = value;
                this.OnPropertyChanged(nameof(InputMessage));
            }
        }

        public ICommand UpdateBodyMessageCommand { get; }
        public ICommand OpenFilePickerCommand { get; }

        public MainPageViewModel()
        {
            this.UpdateBodyMessageCommand = new UpdateBodyMessage(this);
            this.OpenFilePickerCommand = new OpenFilePickerCommand(this);
        }
    }
}
