using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TestingSystemData;
using TestingSystemData.Model;
using TestingSystemData.MVVM;

namespace ClientApp.ViewModel
{
    class LectionsViewModel : ViewModelBase
    {
        private Lection selectedLection;
        public Lection SelectedLection
        {
            get => selectedLection;
            set
            {
                selectedLection = value;
                OnPropertyChanged("SelectedLection");
            }
        }


        public ObservableCollection<IGrouping<string, Lection>> LectionsGroups { get; set; }


        public LectionsViewModel()
        {
            try
            {
                LectionsGroups = new ObservableCollection<IGrouping<string, Lection>>(Core.Context.Lections.GroupBy(x => x.Group).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Command selectCommand = null!;
        public Command SelectCommand
        {
            get => selectCommand ??= new Command(obj =>
        {
            SelectedLection = (Lection)obj;
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
