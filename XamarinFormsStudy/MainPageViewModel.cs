using System;
using System.IO;
using System.Windows.Input;
using XamarinFormsStudy.Views;
using XamarinFormsStudy.Commands;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

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

        public ObservableCollection<FileInfo> FileInfoList { get; set; }

        public ICommand UpdateBodyMessageCommand { get; }
        public ICommand OpenFilePickerCommand { get; }

        public MainPageViewModel()
        {
            this.UpdateBodyMessageCommand = new UpdateBodyMessage(this);
            this.OpenFilePickerCommand = new OpenFilePickerCommand(this);

            var path = Environment.GetFolderPath(
                Environment.SpecialFolder.UserProfile);

            var files = Directory.EnumerateFileSystemEntries(path).OrderBy(value => value);
            

            this.FileInfoList = new ObservableCollection<FileInfo>();

            var parentPath = new FileInfo();
            parentPath.IsFile = false;
            parentPath.IsSelected = false;
            parentPath.IsSelectable = false;
            parentPath.Title = "..";
            parentPath.Path = Directory.GetParent(path).ToString();
            parentPath.GridBackgroundColor = Color.LightYellow;
            parentPath.CheckBoxBackgroundColor = Color.Gray;
            this.FileInfoList.Add(parentPath);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo();
                fileInfo.IsFile = !
                    File.GetAttributes(file).HasFlag(FileAttributes.Directory);
                fileInfo.IsSelected = false;
                fileInfo.IsSelectable = true;
                fileInfo.Title = file.Replace(path + Path.DirectorySeparatorChar, "");
                fileInfo.Path = file;
                fileInfo.GridBackgroundColor = (fileInfo.IsFile) ? Color.White : Color.LightYellow;
                fileInfo.CheckBoxBackgroundColor = Color.White;
                this.FileInfoList.Add(fileInfo);
            }

        }
    }

    public class FileInfo
    {
        public bool IsFile { get; set; }
        public bool IsSelected { get; set; }
        public bool IsSelectable { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public Color GridBackgroundColor { get; set; }
        public Color CheckBoxBackgroundColor { get; set; }
    }
}
