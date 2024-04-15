using LibraryTrackingApp.Application.Features.Books.Commands.Requests;
using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Application.Features.Authors.Behaviors.Mapping;

public class AuthorMappingProfile : Profile
{
    public AuthorMappingProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
        CreateMap<Book, CreateBookCommandRequest>().ReverseMap();
        CreateMap<BookDTO, CreateBookCommandRequest>().ReverseMap();
    }
}
