using CapitalTask.Models;

namespace CapitalTask.DTO
{
    public class ApplicationTemplateDto
    {
        public List<CapitalTask.DTO.QuestionDto> Questions { get; set; }

        public int Id { get; set; }
        public int ProgramId { get; set; }
        
        public string Text { get; set; }
        public QuestionType Type { get; set; }
    }
}
