using CapitalTask.DTO;
using CapitalTask.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowsController : ControllerBase
    {

        private readonly IWorkflowService _workflowService;

        public WorkflowsController(IWorkflowService workflowService)
        {
            _workflowService = workflowService;
        }

        // GET: api/Workflows/5
        [HttpGet("{programId}")]
        public async Task<ActionResult<WorkflowDto>> GetWorkflow(int programId)
        {
            var workflow = await _workflowService.GetWorkflow(programId);
            if (workflow == null)
                return NotFound();
            return workflow;
        }

        // PUT: api/Workflows/5
        [HttpPut("{programId}")]
        public async Task<IActionResult> PutWorkflow(int programId, WorkflowDto workflowDto)
        {
            if (programId != workflowDto.ProgramId)
                return BadRequest();
            await _workflowService.UpdateWorkflow(workflowDto);
            return NoContent();
        }

    }
}
