using CapitalTask.DTO;

namespace CapitalTask.IServices
{
    public interface IProgramService
    {
        Task<ProgramDto> GetProgram(int id);
        Task<ProgramDto> AddProgram(ProgramDto programDto);
        Task<ProgramDto> UpdateProgram(ProgramDto programDto);
    }
}
