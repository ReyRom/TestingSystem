using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestingSystemData.Model;

namespace TestingSystemData
{
    public class QuestionsList : ObservableCollection<Question>
    {
        public QuestionsList(IEnumerable<Question> collection) : base(collection)
        {
        }

        public QuestionsList()
        {
        }

        public QuestionsList(List<Question> list) : base(list)
        {
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            RefreshNumbers();
        }
        public void RefreshNumbers()
        {
            int i = 1;
            foreach (Question question in this)
            {
                question.Number = i;
                i++;
            }
        }
    }
}
