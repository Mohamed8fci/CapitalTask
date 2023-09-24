namespace CapitalTask.Models
{
    public enum StageType
    {
        Shortlisting,
        VideoInterview,
        Placement
    }
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StageType Type { get; set; }
    }
}
