using CapitalTask.Models;

namespace CapitalTask.DTO
{
    public enum StageType
    {
        Shortlisting,
        VideoInterview,
        Placement
    }
    public class WorkflowDto
    {
        public List<CapitalTask.DTO.StageDto> Stages { get; set; }

        public int Id { get; set; }
        public int ProgramId { get; set; }
        public string Name { get; set; }
        public StageType Type { get; set; }

    }
}
