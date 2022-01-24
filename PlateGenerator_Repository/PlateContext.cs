using Microsoft.EntityFrameworkCore;
using PlateGenerator_Model;

namespace PlateGenerator_Repository
{
    public class PlateContext : DbContext
    {
        public DbSet<Plate> Plates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=PLM\SQLEXPRESS; Initial Catalog=plm-plates; Integrated Security = True");
        }
    }
}
