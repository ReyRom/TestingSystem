using ClientApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystemData.MVVM;

namespace ClientApp.ViewModel
{
    public class StartViewModel : ViewModelBase
    {
        public string Username
        {
            get => App.Username;
            set
            {
                App.Username = value;
                OnPropertyChanged("Username");
            }
        }


        Command navigateTestsCommand;
        public Command NavigateTestsCommand => navigateTestsCommand ?? (navigateTestsCommand = new Command(username =>
        {
            MainWindow.NavigationHelper.Navigate(new TestsPage());
        }, username => !string.IsNullOrWhiteSpace((string)username)));


        Command navigateLectionsCommand;
        public Command NavigateLectionsCommand => navigateLectionsCommand ?? (navigateLectionsCommand = new Command(username =>
        {
            MainWindow.NavigationHelper.Navigate(new LectionsPage());
        }));
    }
}
