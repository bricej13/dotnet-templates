using Microsoft.EntityFrameworkCore;
using Webapi.Template.DB;
using Webapi.Template.DB.Entities;

namespace Webapi.Template.Core.Services;

public class BlogService : IBlogService
{
    private readonly DataContext _db;

    public BlogService(DataContext db)
    {
        _db = db;
    }

    public ValueTask<Blog?> Get(int blogId)
    {
        return _db.Blogs.FindAsync(blogId);
    }

    public Task<List<Blog>> All()
    {
        return _db.Blogs.ToListAsync();
    }
}