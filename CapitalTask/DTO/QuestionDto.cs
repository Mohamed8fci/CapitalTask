using CapitalTask.Models;

namespace CapitalTask.DTO
{
   
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public string Text { get; set; }
       // public QuestionType Type { get; set; }
    }
}
