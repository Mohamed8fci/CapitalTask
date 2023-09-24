namespace CapitalTask.DTO
{
    public class ProgramDto
    {
        public int Id { get; set; }
        public string ProgramTitle { get; set; }
        public string Summary { get; set; }
        public string ProgramDescription { get; set; }
        public string ProgramBenefits { get; set; }
        public string keySkills { get; set; }
        public string ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationStart { get; set; }
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        public string ProgramLocation { get; set; }
        public string MinQualification { get; set; }
        public int MaxNumberOfApplications { get; set; }
    }
}
