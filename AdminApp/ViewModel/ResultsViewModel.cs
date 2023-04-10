using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using TestingSystemData;
using TestingSystemData.Model;
using TestingSystemData.MVVM;

namespace AdminApp.ViewModel
{
    public class ResultsViewModel : ViewModelBase
    {
        public ResultsViewModel()
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                Results = new ObservableCollection<Result>(Core.Context.Results.OrderByDescending(x=>x.DateTime));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ObservableCollection<Result> results = new ObservableCollection<Result>();
        public ObservableCollection<Result> Results
        {
            get => results;
            set
            {
                results = value;
                OnPropertyChanged(nameof(Results));
            }
        }

        Command deleteCommand = null!;
        public Command DeleteCommand
        {
            get => deleteCommand ??= new Command(obj =>
            {
                try
                {
                    Core.Context.Results.Remove((Result)obj);
                    Core.Context.SaveChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        Command renewCommand = null!;
        public Command RenewCommand
        {
            get => renewCommand ??= new Command(obj =>
            {
                LoadData();
            });
        }

        Command saveCommand = null!;
        public Command SaveCommand
        {
            get => saveCommand ??= new Command(obj =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы|*.txt";
                if (saveFileDialog.ShowDialog()??false)
                {
                    var result = (Result)obj;
                    File.WriteAllText(saveFileDialog.FileName, $"{result.Test.Name}\n{result.Username} - {result.ScoreString} - {result.DateTime}\n {result.TestLog}");
                }
            });
        }
    }
}
