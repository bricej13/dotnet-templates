using Microsoft.EntityFrameworkCore;
using Webapi.Template.DB;
using Webapi.Template.DB.Entities;

namespace Webapi.Template.Core.Services;

public interface IPostService
{
    ValueTask<Post?> Get(int postId);
    Task<List<Post>> ForAuthor(int authorId);
    Task<List<Post>> ForBlog(int blogId);
}

public class PostService : IPostService
{
    private readonly DataContext _db;

    public PostService(DataContext db)
    {
        _db = db;
    }

    public ValueTask<Post?> Get(int postId)
    {
        return _db.Posts.FindAsync(postId);
    }

    public Task<List<Post>> ForAuthor(int authorId)
    {
        return _db.Posts.Where(p => p.AuthorId.Equals(authorId)).ToListAsync();
    }

    public Task<List<Post>> ForBlog(int blogId)
    {
        return _db.Posts.Where(p => p.BlogId.Equals(blogId)).ToListAsync();
    }
}