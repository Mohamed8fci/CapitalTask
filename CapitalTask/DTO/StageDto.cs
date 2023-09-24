using CapitalTask.Models;

namespace CapitalTask.DTO
{
    
    public class StageDto
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public string Name { get; set; }
        public StageType Type { get; set; }
        public List<Stage> Stages { get; set; }
    }
}
