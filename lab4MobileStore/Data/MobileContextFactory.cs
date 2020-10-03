using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace lab4MobileStore.Data
{
    public class MobileContextFactory : IDesignTimeDbContextFactory<MobileContext>
    {
        public MobileContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MobileContext>();
            optionsBuilder.UseSqlite("Data Source=mobilestoredb.db");

            return new MobileContext(optionsBuilder.Options);
        }
    }
}
