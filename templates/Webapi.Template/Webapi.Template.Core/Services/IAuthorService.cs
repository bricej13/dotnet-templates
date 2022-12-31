using Webapi.Template.DB.Entities;

namespace Webapi.Template.Core.Services;

public interface IAuthorService
{
    ValueTask<Author?> Get(int authorId);
    Task<List<Author>> GetAll();
    Task<List<Author>> GetForBlog(int blogId);
}