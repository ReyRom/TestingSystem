using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using TestingSystemData.Model;
using ClientApp.ViewModel;

namespace ClientApp.Resources
{
    public class AnswerTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OneAnswer { get; set; }
        public DataTemplate ManyAnswer { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return ((Answer)item).Type == QuestionType.One ? OneAnswer : ManyAnswer;
        }
    }
}
