using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestingSystemData.Model;

namespace AdminApp.View
{
    /// <summary>
    /// Логика взаимодействия для EditTestWindow.xaml
    /// </summary>
    public partial class EditTestWindow : Window
    {
        public static EditTestWindow Instance { get; set; }
        public EditTestWindow(Test test)
        {
            Instance = this;
            Test = test;
            InitializeComponent();
        }
        
        public static Test Test { get; set; }
    }
}
