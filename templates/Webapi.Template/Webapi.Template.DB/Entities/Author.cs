using System.ComponentModel.DataAnnotations;

namespace Webapi.Template.DB.Entities;

public class Author : BaseEntity<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public virtual List<Post> Posts { get; set; }
}