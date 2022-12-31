using System.ComponentModel.DataAnnotations;

namespace Webapi.Template.DB.Entities;

public class Blog : BaseEntity<int>
{
    public string Name { get; set; }
    public List<Post> Posts { get; set; }
    public List<Author> Authors { get; set; }
}