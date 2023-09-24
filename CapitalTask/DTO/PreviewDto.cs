namespace CapitalTask.DTO
{
    public class PreviewDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ProgramDto ProgramTab { get; set; }
        public ApplicationTemplateDto ApplicationTemplate { get; set; }
        public WorkflowDto Workflow { get; set; }
    }
}
