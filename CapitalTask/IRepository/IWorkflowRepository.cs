using CapitalTask.Models;

namespace CapitalTask.IRepository
{
    public interface IWorkflowRepository
    {
        Task<Workflow> GetWorkflow(int programId);
        Task<Workflow> UpdateWorkflow(Workflow workflow);
    }
}
