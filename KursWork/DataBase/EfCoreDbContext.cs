
using Microsoft.EntityFrameworkCore;

namespace KursWork.DataBase
{
    public class EfCoreDbContext : DbContext
    {
        private readonly string _connectionString = "Server=DESKTOP-SM098C1;Database=Lab2;Trusted_Connection=True;";

        public EfCoreDbContext()
        {
                
        }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Organizations> Organizations { get; set; }
        public DbSet<PlanTable> PlanTable { get; set; }
        public DbSet<Specializations> Specializations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            
            builder.UseSqlServer(_connectionString);
            base.OnConfiguring(builder);
        }
    }
}
