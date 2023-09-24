using CapitalTask.DTO;
using CapitalTask.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationTemplatesController : ControllerBase
    {
        private readonly IApplicationTemplateService _applicationTemplateService;

        public ApplicationTemplatesController(IApplicationTemplateService applicationTemplateService)
        {
            _applicationTemplateService = applicationTemplateService;
        }

        // GET: api/ApplicationTemplates/5
        [HttpGet("{programId}")]
        public async Task<ActionResult<ApplicationTemplateDto>> GetApplicationTemplate(int programId)
        {
            var applicationTemplate = await _applicationTemplateService.GetApplicationTemplate(programId);
            if (applicationTemplate == null)
                return NotFound();
            return applicationTemplate;
        }

        [HttpPut("{programId}")]
        public async Task<IActionResult> PutApplicationTemplate(int programId, ApplicationTemplateDto applicationTemplateDto)
        {
            if (programId != applicationTemplateDto.ProgramId)
                return BadRequest();
            await _applicationTemplateService.UpdateApplicationTemplate(applicationTemplateDto);
            return NoContent();
        }
    }
}
