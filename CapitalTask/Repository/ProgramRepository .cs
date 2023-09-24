using CapitalTask.IRepository;
using CapitalTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalTask.Repository
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly StoreContext _context;

        public ProgramRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<ProgramTab> GetProgram(int id)
        {
            return await _context.Programs.FindAsync(id);
        }

        public async Task<ProgramTab> AddProgram(ProgramTab program)
        {
            _context.Programs.Add(program);
            await _context.SaveChangesAsync();
            return program;
        }

        public async Task<ProgramTab> UpdateProgram(ProgramTab program)
        {
            _context.Entry(program).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return program;
        }

        }
    }

