namespace CapitalTask.Models
{
    public class Workflow
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public List<Stage> Stages { get; set; }
    }
}
