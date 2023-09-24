namespace CapitalTask.Models
{
    public class ApplicationTemplate
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public List<Question> Questions { get; set; }
    }
}
