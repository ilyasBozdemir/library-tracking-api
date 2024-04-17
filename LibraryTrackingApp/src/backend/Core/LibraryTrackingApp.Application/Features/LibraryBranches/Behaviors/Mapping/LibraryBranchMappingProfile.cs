using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Behaviors.Mapping;

public class LibraryBranchMappingProfile : Profile
{
    public LibraryBranchMappingProfile()
    {
        CreateMap<CreateLibraryBranchDTO, LibraryBranch>().ReverseMap();
    }
}