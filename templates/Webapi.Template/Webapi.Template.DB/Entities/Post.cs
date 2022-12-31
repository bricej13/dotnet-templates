using System.ComponentModel.DataAnnotations;

namespace Webapi.Template.DB.Entities;

public class Post : BaseEntity<int>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset PublishDate { get; set; }
    
    public Author Author { get; set; }
    public int AuthorId { get; set; }
    public Blog Blog { get; set; }
    public int BlogId { get; set; }
}