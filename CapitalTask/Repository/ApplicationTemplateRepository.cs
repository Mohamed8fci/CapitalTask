using CapitalTask.IRepository;
using CapitalTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalTask.Repository
{
    public class ApplicationTemplateRepository : IApplicationTemplateRepository
    {
        private readonly StoreContext _context;

        public ApplicationTemplateRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<ApplicationTemplate> GetApplicationTemplate(int programId)
        {
            return await _context.ApplicationTemplates.FirstOrDefaultAsync(a => a.ProgramId == programId);
        }

        public async Task<ApplicationTemplate> UpdateApplicationTemplate(ApplicationTemplate applicationTemplate)
        {
            _context.Entry(applicationTemplate).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return applicationTemplate;
        }
    }
}
