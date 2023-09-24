using CapitalTask.IRepository;
using CapitalTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalTask.Repository
{
    public class WorkflowRepository : IWorkflowRepository
    {
        private readonly StoreContext _context;

        public WorkflowRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Workflow> GetWorkflow(int programId)
        {
            return await _context.Workflows.FirstOrDefaultAsync(w => w.ProgramId == programId);
        }

        public async Task<Workflow> UpdateWorkflow(Workflow workflow)
        {
            _context.Entry(workflow).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return workflow;
        }
    }
}
