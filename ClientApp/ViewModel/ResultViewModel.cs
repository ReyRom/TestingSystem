using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystemData;
using TestingSystemData.MVVM;

namespace ClientApp.ViewModel
{
    public class ResultViewModel:ViewModelBase
    {
        public Result Result { get; set; }

        Command navigateTestsCommand;
        public Command NavigateTestsCommand => navigateTestsCommand ?? (navigateTestsCommand = new Command(obj =>
        {
            MainWindow.NavigationHelper.GoBack();
            MainWindow.NavigationHelper.GoBack();
        }));
    }
}
