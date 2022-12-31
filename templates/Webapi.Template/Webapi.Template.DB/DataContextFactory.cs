using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Webapi.Template.DB;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlite("Data Source=fake.db"); //  TODO: Update to correct db provider
            return new DataContext(optionsBuilder.Options);
        }

}