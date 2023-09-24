using CapitalTask.IRepository;
using CapitalTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalTask.Repository
{
    
        public class PreviewRepository : IPreviewRepository
        {
            private readonly StoreContext _context;

            public PreviewRepository(StoreContext context)
            {
                _context = context;
            }

            public async Task<List<Preview>> GetAllPreviews()
            {
                return await _context.Previews.ToListAsync();
            }

            public async Task<Preview> GetPreviewById(int id)
            {
                return await _context.Previews.FindAsync(id);
            }
        }
}
