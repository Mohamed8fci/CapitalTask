using CapitalTask.DTO;
using CapitalTask.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramService _programService;

        public ProgramsController(IProgramService programService)
        {
            _programService = programService;
        }

        
        [HttpPost]
        public async Task<ActionResult<ProgramDto>> PostProgram(ProgramDto programDto)
        {
            var program = await _programService.AddProgram(programDto);
            return CreatedAtAction("GetProgram", new { id = program.Id }, program);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProgramDto>> GetProgram(int id)
        {
            var program = await _programService.GetProgram(id);
            if (program == null)
                return NotFound();
            return program;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgram(int id, ProgramDto programDto)
        {
            if (id != programDto.Id)
                return BadRequest();
            await _programService.UpdateProgram(programDto);
            return NoContent();
        }
    }
}
