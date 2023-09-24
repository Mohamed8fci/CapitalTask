using CapitalTask.Models;

namespace CapitalTask.IRepository
{
    public interface IApplicationTemplateRepository
    {
        Task<ApplicationTemplate> GetApplicationTemplate(int programId);
        Task<ApplicationTemplate> UpdateApplicationTemplate(ApplicationTemplate applicationTemplate);
    }
}
