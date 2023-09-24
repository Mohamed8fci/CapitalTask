using CapitalTask.DTO;
using CapitalTask.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        private readonly IProgramService _programService;
        private readonly IApplicationTemplateService _applicationTemplateService;
        private readonly IWorkflowService _workflowService;

        public PreviewController(IProgramService programService, IApplicationTemplateService applicationTemplateService, IWorkflowService workflowService)
        {
            _programService = programService;
            _applicationTemplateService = applicationTemplateService;
            _workflowService = workflowService;
        }

        [HttpGet("{programId}")]
        public async Task<ActionResult<PreviewDto>> GetPreview(int programId)
        {
            var program = await _programService.GetProgram(programId);
            var applicationTemplate = await _applicationTemplateService.GetApplicationTemplate(programId);
            var workflow = await _workflowService.GetWorkflow(programId);

            if (program == null || applicationTemplate == null || workflow == null)
                return NotFound();

            var previewDto = new PreviewDto
            {
                ProgramTab = program,
                ApplicationTemplate = applicationTemplate,
                Workflow = workflow
            };

            return previewDto;
        }
    }
}
