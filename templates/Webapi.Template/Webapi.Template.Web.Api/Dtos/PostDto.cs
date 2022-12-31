namespace Webapi.Template.Web.Api.Dtos;

public class PostDto
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset PublishDate { get; set; }
    public AuthorDto Author { get; set; }
    public int AuthorId { get; set; }
}