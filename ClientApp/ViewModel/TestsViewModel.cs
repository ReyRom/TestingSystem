using ClientApp.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TestingSystemData;
using TestingSystemData.Model;
using TestingSystemData.MVVM;

namespace ClientApp.ViewModel
{
    public class TestsViewModel : ViewModelBase
    {
        private Test selectedTest;
        public Test SelectedTest
        {
            get => selectedTest;
            set
            {
                selectedTest = value;
                OnPropertyChanged("SelectedTest");
            }
        }

        public TestsViewModel()
        {
            try
            {
                Tests = new ObservableCollection<Test>(Core.Context.Tests.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ObservableCollection<Test> Tests { get; set; }

        Command startTestCommand = null!;
        public Command StartTestCommand => startTestCommand ?? (startTestCommand = new Command(test =>
        {
            MainWindow.NavigationHelper.Navigate(new TestingPage(test as Test));
        }, test => !(test is null)));

        Command selectCommand = null!;
        public Command SelectCommand
        {
            get => selectCommand ??= new Command(obj =>
            {
                SelectedTest = (Test)obj;
            });
        }

        Command goBackCommand = null!;
        public Command GoBackCommand
        {
            get => goBackCommand ??= new Command(obj =>
            {
                MainWindow.NavigationHelper.GoBack();
            });
        }
    }
}
