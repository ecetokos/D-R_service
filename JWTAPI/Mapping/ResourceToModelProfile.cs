using AutoMapper;
using JWTAPI.Controllers.Resources;
using JWTAPI.Core.Models;
using JWTAPI.Resources;
using JWTAPI.Models;

namespace JWTAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<Kategori, CategoryResource>();
            CreateMap<UserCredentialsResource, User>();
        }
    }
}