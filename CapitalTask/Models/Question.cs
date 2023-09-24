namespace CapitalTask.Models
{
    public enum QuestionType
    {
        Paragraph,
        ShortAnswer,
        YesNo,
        Dropdown,
        MultipleChoice,
        Date,
        Number,
        FileUpload
    }
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public QuestionType Type { get; set; }
    }
}
