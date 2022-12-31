using AutoMapper;
using Webapi.Template.DB.Entities;
using Webapi.Template.Web.Api.Dtos;

namespace Webapi.Template.Web.Api.AutomapperProfiles;

public class AutomapperProfile : Profile
{
    public AutomapperProfile()
    {
        CreateMap<Author, AuthorDto>(); // TODO: Replace with your own entities/DTOs
        CreateMap<Post, PostDto>(); // TODO: Remove
        CreateMap<Blog, BlogDto>(); // TODO: Remove
    }
}