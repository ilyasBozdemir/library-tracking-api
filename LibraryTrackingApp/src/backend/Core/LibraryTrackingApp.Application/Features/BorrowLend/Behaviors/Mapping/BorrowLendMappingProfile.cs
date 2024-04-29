using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Behaviors.Mapping;

public class BorrowLendMappingProfile : Profile
{
    public BorrowLendMappingProfile()
    {
        // BorrowLend ↔ BorrowLendDTO
        CreateMap<Domain.Entities.Library.BorrowLend, BorrowLendDTO>()
            .ReverseMap();

        // BorrowLend ↔ CreateBorrowLendDTO
        CreateMap<Domain.Entities.Library.BorrowLend, CreateBorrowLendDTO>()
            .ReverseMap();

        // BorrowLend ↔ GiveBorrowCommandRequest
        CreateMap<Domain.Entities.Library.BorrowLend, GiveBorrowCommandRequest>()
            .ReverseMap();

        // GiveBorrowCommandRequest ↔ CreateBorrowLendDTO
        CreateMap<GiveBorrowCommandRequest, CreateBorrowLendDTO>()
            .ReverseMap();

        // GiveBorrowCommandRequest ↔ BorrowLendDTO
        CreateMap<GiveBorrowCommandRequest, BorrowLendDTO>()
            .ReverseMap();

        // BorrowLend ↔ TakeBorrowCommandRequest
        CreateMap<Domain.Entities.Library.BorrowLend, TakeBorrowCommandRequest>()
            .ReverseMap();

        // TakeBorrowCommandRequest ↔ CreateBorrowLendDTO
        CreateMap<TakeBorrowCommandRequest, CreateBorrowLendDTO>()
            .ReverseMap();

        // BorrowCommandRequest ↔ BorrowLendDTO
        CreateMap<TakeBorrowCommandRequest, BorrowLendDTO>()
            .ReverseMap();
    }
}
