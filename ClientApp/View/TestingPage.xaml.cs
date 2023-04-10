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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestingSystemData.Model;

namespace ClientApp.View
{
    /// <summary>
    /// Логика взаимодействия для TestingPage.xaml
    /// </summary>
    public partial class TestingPage : Page
    {
        public TestingPage()
        {
            InitializeComponent();
        }

        public TestingPage(Test? test)
        {
            Test = test;
            InitializeComponent();
        }

        public static Test Test { get; set; }
    }
}
