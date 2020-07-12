﻿using System;
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

        private string inputMessage = "hoge";
        public string InputMessage
        {
            get { return inputMessage; }
            set
            {
                this.inputMessage = value;
                this.OnPropertyChanged(nameof(InputMessage));
            }
        }

        public ICommand UpdateBodyMessage { get; }

        public MainPageViewModel()
        {
            this.UpdateBodyMessage = new UpdateBodyMessage(this);
        }
    }
}
