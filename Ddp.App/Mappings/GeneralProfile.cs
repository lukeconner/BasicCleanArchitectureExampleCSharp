using AutoMapper;
using Ddp.Domain.DTOs;
using Ddp.Domain.Models;

namespace Ddp.App.Mappings;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        CreateMap<User, UserPermissionDto>();
    }
}