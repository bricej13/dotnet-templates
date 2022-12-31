using Microsoft.EntityFrameworkCore;
using Webapi.Template.DB.Entities;

namespace Webapi.Template.DB;

public class DataContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public override Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken token = default)
    {
        foreach (var entity in ChangeTracker
                     .Entries()
                     .Where(x => x.Entity is BaseEntity && x.State == EntityState.Modified)
                     .Select(x => x.Entity)
                     .Cast<BaseEntity>())
        {
            entity.UpdatedDate = DateTimeOffset.Now;
        }

        foreach (var entity in ChangeTracker
                     .Entries()
                     .Where(x => x.Entity is BaseEntity && x.State == EntityState.Added)
                     .Select(x => x.Entity)
                     .Cast<BaseEntity>())
        {
            entity.CreatedDate = DateTimeOffset.Now;
            entity.UpdatedDate = entity.CreatedDate;
        }


        return base.SaveChangesAsync(acceptAllChangesOnSuccess, token);
    }

}