using EdDealerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EdDealerAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
