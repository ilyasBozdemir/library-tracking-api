using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Features.Books.Commands.Requests;
using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Application.Features.Books.Behaviors.Mapping;

public class BookMappingProfile : Profile
{
    public BookMappingProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
        CreateMap<Book, CreateBookCommandRequest>().ReverseMap();
        CreateMap<BookDTO, CreateBookCommandRequest>().ReverseMap();

        // lazım olan yerde burda map'leme yapılabilir.
    }
}
