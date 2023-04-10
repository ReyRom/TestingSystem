using AdminApp.View;
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
    public class TestsViewModel : ViewModelBase
    {
        public TestsViewModel()
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                Tests = new ObservableCollection<Test>(Core.Context.Tests.OrderByDescending(x => x.TestId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private ObservableCollection<Test> tests = new ObservableCollection<Test>();
        public ObservableCollection<Test> Tests
        {
            get => tests; set
            {
                tests = value;
                OnPropertyChanged(nameof(Tests));
            }
        }

        Command selectFileCommand = null!;
        public Command SelectFileCommand
        {
            get => selectFileCommand ??= new Command(obj =>
            {
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "XML|*.xml";
                    if (openFileDialog.ShowDialog() ?? false)
                    {
                        var t = (Test)obj;
                        t.XmlContent = File.ReadAllText(openFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }

        Command addCommand = null!;
        public Command AddCommand
        {
            get => addCommand ??= new Command(obj =>
            {
                try
                {
                    var test = new Test();
                    test.Name = "Новый тест";
                    test.Description = "Описание";
                    test.XmlContent = Properties.Resources.TestPlaceholder;
                    Core.Context.Tests.Add(test);
                    Core.Context.SaveChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }
        Command saveCommand = null!;
        public Command SaveCommand
        {
            get => saveCommand ??= new Command(obj =>
            {
                try
                {
                    Core.Context.Tests.Entry((Test)obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Core.Context.SaveChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        Command deleteCommand = null!;
        public Command DeleteCommand
        {
            get => deleteCommand ??= new Command(obj =>
            {
                try
                {
                    Core.Context.Tests.Remove((Test)obj);
                    Core.Context.SaveChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }

        Command editCommand = null!;
        public Command EditCommand
        {
            get => editCommand ??= new Command(obj =>
            {
                EditTestWindow editTestWindow = new EditTestWindow((Test)obj);
                editTestWindow.ShowDialog();
            });
        }
    }
}
