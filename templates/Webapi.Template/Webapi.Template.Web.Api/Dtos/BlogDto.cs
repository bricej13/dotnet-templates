namespace Webapi.Template.Web.Api.Dtos;

public class BlogDto
{
    public string Name { get; set; }
    public List<PostDto> Posts { get; set; }
    public List<AuthorDto> Authors { get; set; }
}