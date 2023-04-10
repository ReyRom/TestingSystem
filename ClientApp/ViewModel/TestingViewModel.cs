using ClientApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using TestingSystemData;
using TestingSystemData.Model;
using TestingSystemData.MVVM;

namespace ClientApp.ViewModel
{
    class TestingViewModel : ViewModelBase
    {
        private Test test;
        public Test Test
        {
            get => test;
            set
            {
                try
                {
                    test = value;
                    if (test != null)
                    {
                        questions = Question.ParseFromXml(Test.XmlContent);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                OnPropertyChanged(nameof(Test));
            }
        }

        private List<Question> questions = new List<Question>();
        public List<Question> Questions
        {
            get => questions;
        }

        string log = string.Empty;
        int score = 0;
        public bool IsNextQuestion { get => questionIndex < Questions.Count - 1; }

        int questionIndex = 0;

        public int QuestionNumber { get => questionIndex + 1; }

        public int QuestionIndex
        {
            get => questionIndex;
            set
            {
                questionIndex = value;
                OnPropertyChanged("QuestionIndex");
                OnPropertyChanged("CurrentQuestion");
                OnPropertyChanged("IsNextQuestion");
            }
        }

        public Question CurrentQuestion
        {
            get => Questions.ElementAtOrDefault(QuestionIndex);
        }

        Command nextQuestionCommand = null!;
        public Command NextQuestionCommand => nextQuestionCommand ?? (nextQuestionCommand = new Command(item =>
        {
            var q = (Question)item;
            log += $"{QuestionNumber}) " + q.GetLog();
            if (q.Correct) score++;
            QuestionIndex++;
        }));

        Command finishTestCommand = null!;
        public Command FinishTestCommand => finishTestCommand ?? (finishTestCommand = new Command(item =>
        {
            try
            {
                var q = (Question)item;
                log += $"{QuestionNumber}) " + q.GetLog();
                if (q.Correct) score++;

                Result result = new Result();
                result.Test = Test;
                result.Score = score;
                result.MaxScore = Questions.Count;
                result.DateTime = DateTime.Now;
                result.Username = App.Username;
                result.TestLog = log;
                Core.Context.Results.Add(result);
                Core.Context.SaveChanges();

                MainWindow.NavigationHelper.Navigate(new ResultPage(result));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }));
    }
}
