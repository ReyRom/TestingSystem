using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using TestingSystemData.MVVM;

namespace TestingSystemData.Model
{
    public class Question : ViewModelBase
    {
        private int number;

        public Question()
        {
            Text = "";
            Answers = new List<Answer>();
            Type = QuestionType.One;
        }
        public int Number
        {
            get => number; set
            {
                number = value;
                OnPropertyChanged(nameof(Number));
            }
        }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public QuestionType Type { get; set; }

        public bool Correct
        {
            get
            {
                foreach (var answer in Answers)
                {
                    if (answer.IsCorrect != answer.IsSelected)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public string GetLog()
        {

            StringBuilder builder = new StringBuilder();
            builder.AppendLine(Text);

            foreach (var answer in Answers)
            {
                builder.AppendLine($"({(answer.IsCorrect ? "✔" : "❌")}|{(answer.IsSelected ? "🔴" : "⚪")}) {answer.Text}");
            }
            builder.AppendLine(Correct ? "1 балл" : "0 баллов");
            builder.AppendLine();
            return builder.ToString();

        }

        public static List<Question> ParseFromXml(string xml)
        {
            var list = new List<Question>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            var root = doc.DocumentElement;
            var items = root.ChildNodes;
            int i = 1;
            foreach (XmlElement item in items)
            {
                Question question = new Question();
                question.Text = item.Attributes["Text"].Value;
                question.Type = (QuestionType)Enum.Parse(typeof(QuestionType), item.Attributes["Type"].Value);
                foreach (XmlElement answ in item.ChildNodes)
                {
                    Answer answer = new Answer();
                    answer.Text = answ.InnerText;
                    answer.IsCorrect = answ.HasAttribute("IsCorrect");
                    answer.Type = question.Type;
                    answer.IsSelected = false;
                    question.Answers.Add(answer);
                }
                question.Answers = question.Answers.Shuffle().ToList();
                question.Number = i++;
                list.Add(question);
            }
            return list.Shuffle().ToList();
        }
        public static string ParseToXml(List<Question> questions)
        {
            XDocument document = new XDocument();
            XElement root = new XElement("Test");
            foreach (var item in questions)
            {
                XElement q = new XElement("Question");
                XAttribute type = new XAttribute("Type", item.Type);
                XAttribute text = new XAttribute("Text", item.Text);
                q.Add(type);
                q.Add(text);
                foreach (var a in item.Answers)
                {
                    XElement answer = new XElement("Answer", a.Text);
                    if (a.IsCorrect)
                    {
                        XAttribute isCorrect = new XAttribute("IsCorrect", true);
                        answer.Add(isCorrect);
                    }
                    q.Add(answer);
                }
                root.Add(q);
            }
            document.Add(root);

            return document.ToString();
        }
    }
}
