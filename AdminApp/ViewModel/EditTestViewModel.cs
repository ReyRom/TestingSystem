using AdminApp.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TestingSystemData;
using TestingSystemData.Model;
using TestingSystemData.MVVM;

namespace AdminApp.ViewModel
{
    public class EditTestViewModel : ViewModelBase
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
                        Questions = new QuestionsList(Question.ParseFromXml(Test.XmlContent));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                OnPropertyChanged(nameof(Test));
            }
        }

        private QuestionsList questions = new QuestionsList();
        public QuestionsList Questions
        {
            get => questions;
            set
            {
                questions = value;
                questions.RefreshNumbers();
                OnPropertyChanged(nameof(Questions));
            }
        }

        ObservableCollection<Answer> currentAnswers = new ObservableCollection<Answer>();
        public ObservableCollection<Answer> CurrentAnswers
        {
            get => currentAnswers; set
            {
                currentAnswers = value;
                OnPropertyChanged(nameof(CurrentAnswers));
            }
        }


        Question currentQuestion;
        public Question CurrentQuestion
        {
            get => currentQuestion; set
            {
                if (currentQuestion != null)
                {
                    currentQuestion.Answers = CurrentAnswers.ToList();
                    currentQuestion.Type = currentQuestion.Answers.Where(x => x.IsCorrect).Count() > 1 ? QuestionType.Many : QuestionType.One;
                }

                currentQuestion = value;
                CurrentAnswers = new ObservableCollection<Answer>(currentQuestion.Answers);
                OnPropertyChanged(nameof(CurrentQuestion));
            }
        }

        Command addQuestionCommand = null!;
        public Command AddQuestionCommand => addQuestionCommand ??= new Command(obj =>
        {
            Questions.Add(new Question());
        });

        Command addAnswerCommand = null!;
        public Command AddAnswerCommand => addAnswerCommand ??= new Command(obj =>
        {
            CurrentAnswers.Add(new Answer());
        }, obj => obj != null);

        Command selectQuestionCommand = null!;
        public Command SelectQuestionCommand => selectQuestionCommand ??= new Command(obj =>
        {
            CurrentQuestion = (Question)obj;
        });

        Command exitCommand = null!;
        public Command ExitCommand => exitCommand ??= new Command(obj =>
        {
            EditTestWindow.Instance.DialogResult = false;
        });

        Command deleteQuestionCommand = null!;
        public Command DeleteQuestionCommand => deleteQuestionCommand ??= new Command(obj =>
        {
            Questions.Remove(CurrentQuestion);
            OnPropertyChanged(nameof(Questions));
            CurrentQuestion = Questions.FirstOrDefault();
        }, obj => ((QuestionsList)obj)?.Count > 1);

        Command exitSaveCommand = null!;
        public Command ExitSaveCommand => exitSaveCommand ??= new Command(obj =>
        {
            CurrentQuestion.Answers = CurrentAnswers.ToList();
            currentQuestion.Type = currentQuestion.Answers.Where(x => x.IsCorrect).Count() > 1 ? QuestionType.Many : QuestionType.One;
            Test.XmlContent = Question.ParseToXml(Questions.ToList());
            Core.Context.Tests.Entry(Test).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Core.Context.SaveChanges();
            EditTestWindow.Instance.DialogResult = true;
        });
    }
}
