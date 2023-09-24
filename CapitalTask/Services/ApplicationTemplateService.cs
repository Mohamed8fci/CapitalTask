using CapitalTask.DTO;
using CapitalTask.IRepository;
using CapitalTask.IServices;
using CapitalTask.Models;

namespace CapitalTask.Services
{
    public class ApplicationTemplateService : IApplicationTemplateService
    {
        private readonly IApplicationTemplateRepository _applicationTemplateRepository;

        public ApplicationTemplateService(IApplicationTemplateRepository applicationTemplateRepository)
        {
            _applicationTemplateRepository = applicationTemplateRepository;
        }

        public async Task<ApplicationTemplateDto> GetApplicationTemplate(int programId)
        {
            var applicationTemplate = await _applicationTemplateRepository.GetApplicationTemplate(programId);
            return MapToDto(applicationTemplate);
        }

        public async Task<ApplicationTemplateDto> UpdateApplicationTemplate(ApplicationTemplateDto applicationTemplateDto)
        {
            var applicationTemplate = MapToModel(applicationTemplateDto);
            applicationTemplate = await _applicationTemplateRepository.UpdateApplicationTemplate(applicationTemplate);
            return MapToDto(applicationTemplate);
        }

       private ApplicationTemplateDto MapToDto(ApplicationTemplate applicationTemplate)
{
    return new ApplicationTemplateDto
    {
        Id = applicationTemplate.Id,
        ProgramId = applicationTemplate.ProgramId,
        Questions = applicationTemplate.Questions.Select(q => new QuestionDto
        {
            Id = q.Id,
            Text = q.Text
        }).ToList()
    };
}

        private ApplicationTemplate MapToModel(ApplicationTemplateDto applicationTemplateDto)
        {
            return new ApplicationTemplate
            {
                Id = applicationTemplateDto.Id,
                ProgramId = applicationTemplateDto.ProgramId,
                Questions = applicationTemplateDto.Questions.Select(q => new Question
                {
                    Id = q.Id,
                    Text = q.Text,
                    //Type = q.Type
                }).ToList()
            };
        }
    }
}
