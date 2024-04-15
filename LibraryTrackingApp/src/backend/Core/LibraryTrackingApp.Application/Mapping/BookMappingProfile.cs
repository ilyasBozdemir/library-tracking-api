using LibraryTrackingApp.Application.Features.Commands.Book;
using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Application.Mapping;

public class BookMappingProfile : Profile
{
    public BookMappingProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
        CreateMap<Book, CreateBookCommandRequest>().ReverseMap();
        CreateMap<BookDTO, CreateBookCommandRequest>().ReverseMap();
    }
}
