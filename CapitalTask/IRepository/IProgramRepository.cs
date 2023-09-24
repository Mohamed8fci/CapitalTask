using CapitalTask.Models;

namespace CapitalTask.IRepository
{
    public interface IProgramRepository
    {
        Task<ProgramTab> GetProgram(int id);
        Task<ProgramTab> AddProgram(ProgramTab program);
        Task<ProgramTab> UpdateProgram(ProgramTab program);
    }
}
