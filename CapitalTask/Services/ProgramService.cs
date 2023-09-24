using CapitalTask.DTO;
using CapitalTask.IRepository;
using CapitalTask.IServices;
using CapitalTask.Models;

namespace CapitalTask.Services
{
    public class ProgramService : IProgramService
    {
        private readonly IProgramRepository _programRepository;

        public ProgramService(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        public async Task<ProgramDto> GetProgram(int id)
        {
            var program = await _programRepository.GetProgram(id);
            return new ProgramDto {
                Id = program.Id, 
                ProgramTitle = program.ProgramTitle, 
                Summary = program.Summary ,
                ProgramBenefits = program.ProgramBenefits,
                ProgramDescription = program.ProgramDescription,
                ProgramLocation = program.ProgramLocation,
                ProgramStart = program.ProgramStart,
                ApplicationClose = program.ApplicationClose,
                ProgramType = program.ProgramType,
                ApplicationStart = program.ApplicationStart,
                Duration = program.Duration,
                keySkills= program.keySkills,
                MaxNumberOfApplications = program.MaxNumberOfApplications,
                MinQualification = program.MinQualification,
            };
        }

        public async Task<ProgramDto> AddProgram(ProgramDto programDto)
        {
            var program = new ProgramTab
            {
                Id = programDto.Id,
                ProgramTitle = programDto.ProgramTitle,
                Summary = programDto.Summary,
                ProgramBenefits = programDto.ProgramBenefits,
                ProgramDescription = programDto.ProgramDescription,
                ProgramLocation = programDto.ProgramLocation,
                ProgramStart = programDto.ProgramStart,
                ApplicationClose = programDto.ApplicationClose,
                ProgramType = programDto.ProgramType,
                ApplicationStart = programDto.ApplicationStart,
                Duration = programDto.Duration,
                keySkills = programDto.keySkills,
                MaxNumberOfApplications = programDto.MaxNumberOfApplications,
                MinQualification = programDto.MinQualification,
            };
            program = await _programRepository.AddProgram(program);
            return new ProgramDto {
                Id = program.Id,
                ProgramTitle = program.ProgramTitle,
                Summary = program.Summary,
                ProgramBenefits = program.ProgramBenefits,
                ProgramDescription = program.ProgramDescription,
                ProgramLocation = program.ProgramLocation,
                ProgramStart = program.ProgramStart,
                ApplicationClose = program.ApplicationClose,
                ProgramType = program.ProgramType,
                ApplicationStart = program.ApplicationStart,
                Duration = program.Duration,
                keySkills = program.keySkills,
                MaxNumberOfApplications = program.MaxNumberOfApplications,
                MinQualification = program.MinQualification,
            };
        }

        public async Task<ProgramDto> UpdateProgram(ProgramDto programDto)
        {
            var program = new ProgramTab {
                Id = programDto.Id,
                ProgramTitle = programDto.ProgramTitle,
                Summary = programDto.Summary,
                ProgramBenefits = programDto.ProgramBenefits,
                ProgramDescription = programDto.ProgramDescription,
                ProgramLocation = programDto.ProgramLocation,
                ProgramStart = programDto.ProgramStart,
                ApplicationClose = programDto.ApplicationClose,
                ProgramType = programDto.ProgramType,
                ApplicationStart = programDto.ApplicationStart,
                Duration = programDto.Duration,
                keySkills = programDto.keySkills,
                MaxNumberOfApplications = programDto.MaxNumberOfApplications,
                MinQualification = programDto.MinQualification,
            };
            program = await _programRepository.UpdateProgram(program);
            return new ProgramDto {
                Id = program.Id,
                ProgramTitle = program.ProgramTitle,
                Summary = program.Summary,
                ProgramBenefits = program.ProgramBenefits,
                ProgramDescription = program.ProgramDescription,
                ProgramLocation = program.ProgramLocation,
                ProgramStart = program.ProgramStart,
                ApplicationClose = program.ApplicationClose,
                ProgramType = program.ProgramType,
                ApplicationStart = program.ApplicationStart,
                Duration = program.Duration,
                keySkills = program.keySkills,
                MaxNumberOfApplications = program.MaxNumberOfApplications,
                MinQualification = program.MinQualification,
            };
        }
    }
}
