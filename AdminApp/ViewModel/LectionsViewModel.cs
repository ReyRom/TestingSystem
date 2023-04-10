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
    public class LectionsViewModel : ViewModelBase
    {
        public LectionsViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                Lections = new ObservableCollection<Lection>(Core.Context.Lections.OrderByDescending(x => x.LectionId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ObservableCollection<Lection> lections = new ObservableCollection<Lection>();
        public ObservableCollection<Lection> Lections
        {
            get => lections; set
            {
                lections = value;
                OnPropertyChanged(nameof(Lections));
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
                    openFileDialog.Filter = "PDF|*.pdf";
                    if (openFileDialog.ShowDialog() ?? false)
                    {
                        var l = (Lection)obj;
                        l.LectionContent.Content = File.ReadAllBytes(openFileDialog.FileName);
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
                    var lection = new Lection();
                    lection.Name = "Новая лекция";
                    lection.Group = "Новая группа";
                    var l = Core.Context.Lections.Add(lection);
                    Core.Context.SaveChanges();
                    var lc = new LectionContent();
                    lc.LectionId = lection.LectionId;
                    lc.Content = Properties.Resources.LectionPlaceholder;
                    Core.Context.LectionContents.Add(lc);
                    lection.LectionContent = lc;
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
                    Core.Context.Lections.Entry((Lection)obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Core.Context.SaveChanges();
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            });
        }
        Command deleteCommand = null!;
        public Command DeleteCommand
        {
            get => deleteCommand ??= new Command(obj =>
            {
                try
                {
                    Core.Context.Lections.Remove((Lection)obj);
                    Core.Context.SaveChanges();
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            });
        }
    }
}
