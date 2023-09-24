using CapitalTask.DTO;
using CapitalTask.IRepository;
using CapitalTask.IServices;
using CapitalTask.Models;

namespace CapitalTask.Services
{
    public class WorkflowService : IWorkflowService
    {
        private readonly IWorkflowRepository _workflowRepository;

        public WorkflowService(IWorkflowRepository workflowRepository)
        {
            _workflowRepository = workflowRepository;
        }

        public async Task<WorkflowDto> GetWorkflow(int programId)
        {
            var workflow = await _workflowRepository.GetWorkflow(programId);
            return MapToDto(workflow);
        }

        public async Task<WorkflowDto> UpdateWorkflow(WorkflowDto workflowDto)
        {
            var workflow = MapToModel(workflowDto);
            workflow = await _workflowRepository.UpdateWorkflow(workflow);
            return MapToDto(workflow);
        }

        private WorkflowDto MapToDto(Workflow workflow)
        {
            return new WorkflowDto
            {
                Id = workflow.Id,
                ProgramId = workflow.ProgramId,
                Stages = workflow.Stages.Select(s => new StageDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Type = (DTO.StageType)(int)s.Type // Explicit casting assuming enum values are compatible
                                                      // Or use a mapping function if enum values differ between models and DTOs
                                                      // Type = MapStageType(s.Type)
                }).ToList()
            };
        }

        private Workflow MapToModel(WorkflowDto workflowDto)
        {
            return new Workflow
            {
                Id = workflowDto.Id,
                ProgramId = workflowDto.ProgramId,
                Stages = workflowDto.Stages.Select(s => new Stage
                {
                    Id = s.Id,
                    Name = s.Name,
                    Type = (Models.StageType)s.Type
                }).ToList()
            };
        }
    }
}
