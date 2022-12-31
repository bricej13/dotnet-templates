using AutoMapper;
using Webapi.Template.Api.Dtos;
using Webapi.Template.DB.Entities;

namespace Webapi.Template.Api.AutomapperProfiles;

public class AutomapperProfile : Profile
{
    public AutomapperProfile()
    {
        CreateMap<Author, AuthorDto>(); // TODO: Replace with your own entities/DTOs
        CreateMap<Post, PostDto>(); // TODO: Remove
        CreateMap<Blog, BlogDto>(); // TODO: Remove
    }
}