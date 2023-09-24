using Microsoft.EntityFrameworkCore;

namespace CapitalTask.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<ProgramTab> Programs { get; set; }
        public DbSet<ApplicationTemplate> ApplicationTemplates { get; set; }
        public DbSet<Workflow> Workflows { get; set; }
        public DbSet<Preview> Previews { get; set; }

    }
}
