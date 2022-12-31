using Webapi.Template.DB.Entities;

namespace Webapi.Template.Core.Services;

public interface IBlogService
{
    ValueTask<Blog?> Get(int blogId);
    Task<List<Blog>> All();
}