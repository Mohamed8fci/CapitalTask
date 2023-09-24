using CapitalTask.DTO;

namespace CapitalTask.IServices
{
    public interface IWorkflowService
    {
        Task<WorkflowDto> GetWorkflow(int programId);
        Task<WorkflowDto> UpdateWorkflow(WorkflowDto workflowDto);
    }
}
