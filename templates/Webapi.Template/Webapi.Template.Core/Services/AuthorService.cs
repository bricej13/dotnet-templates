using Microsoft.EntityFrameworkCore;
using Webapi.Template.DB;
using Webapi.Template.DB.Entities;

namespace Webapi.Template.Core.Services;

public class AuthorService : IAuthorService
{
    private readonly DataContext _db;

    public AuthorService(DataContext db)
    {
        _db = db;
    }


    public ValueTask<Author?> Get(int authorId)
    {
        return _db.Authors.FindAsync(authorId);
    }

    public Task<List<Author>> GetAll()
    {
        return _db.Authors.ToListAsync();
    }

    public Task<List<Author>> GetForBlog(int blogId)
    {
        return _db.Authors.Where(a => a.Posts.Any(p => p.BlogId.Equals(blogId)))
            .ToListAsync();
    }
}