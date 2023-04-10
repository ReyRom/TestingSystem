namespace TestingSystemData.Model
{
    public class Answer
    {
        public Answer()
        {
            Text = "";
            IsCorrect = false;
        }
        public QuestionType Type { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public bool IsSelected { get; set; }
    }
}
