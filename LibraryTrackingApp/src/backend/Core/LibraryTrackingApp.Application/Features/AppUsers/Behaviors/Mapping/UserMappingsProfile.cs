using AutoMapper;
using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
using LibraryTrackingApp.Domain.Entities.Identity;


namespace LibraryTrackingApp.Application.Features.AppUsers.Behaviors.Mapping;

public class UserMappingsProfile : Profile
{
    public UserMappingsProfile()
    {

        // AppUser ↔ CreateUserDto
        CreateMap<AppUser, CreateUserDTO>()
            .ReverseMap();

        // AppUser ↔ UserDto
        CreateMap<AppUser, UserDTO>()
            .ReverseMap();



        // CreateUserCommandRequest ↔ CreateUserDto
        CreateMap<CreateUserDTO, CreateUserDTO>()
            .ReverseMap();


        // CreateUserCommandRequest ↔ CreateUserDto
        CreateMap<CreateUserCommandRequest, CreateUserDTO>().ReverseMap();


    }
}
