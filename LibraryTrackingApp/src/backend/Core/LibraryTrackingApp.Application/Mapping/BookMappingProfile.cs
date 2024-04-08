using AutoMapper;
using LibraryTrackingApp.Application.DTOs;
using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Application.Mapping;

public class BookMappingProfile : Profile
{
    public BookMappingProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
    }
}
