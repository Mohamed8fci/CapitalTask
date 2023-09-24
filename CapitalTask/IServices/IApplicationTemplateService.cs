using CapitalTask.DTO;

namespace CapitalTask.IServices
{
    public interface IApplicationTemplateService
    {
        Task<ApplicationTemplateDto> GetApplicationTemplate(int programId);
        Task<ApplicationTemplateDto> UpdateApplicationTemplate(ApplicationTemplateDto applicationTemplateDto);
    }
}
