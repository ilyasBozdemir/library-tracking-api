using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Requests;
using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Behaviors.Mapping;

public class BookMappingProfile : Profile
{
    public BookMappingProfile()
    {
        CreateMap<WorkCatalog, BookDTO>().ReverseMap();
        CreateMap<WorkCatalog, CreateBookCommandRequest>().ReverseMap();
        CreateMap<BookDTO, CreateBookCommandRequest>().ReverseMap();

        // lazım olan yerde burda map'leme yapılabilir.
    }
}
