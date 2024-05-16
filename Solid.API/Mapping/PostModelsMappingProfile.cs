using Solid.Core.DTOs;
using Solid.Core.Models;
using AutoMapper;
using Solid.API.Models;

namespace Solid.API.Mapping
{
    public class PostModelsMappingProfile:Profile
    {
        public PostModelsMappingProfile()
        {
            CreateMap<Guy,GuyPostModel>().ReverseMap();
        }
    }
}
