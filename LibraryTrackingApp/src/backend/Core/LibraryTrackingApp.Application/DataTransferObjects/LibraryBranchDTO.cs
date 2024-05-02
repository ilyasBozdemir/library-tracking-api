namespace LibraryTrackingApp.Application.DataTransferObjects;

public record LibraryBranchDTO : BaseAuditableDTO<Guid>
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Address { get; init; }
    public string PhoneNumber { get; init; }
    public string Description { get; init; }
    public int MaxCheckoutLimit { get; set; } // Azami ödünç alma adedi
    public int MinCheckoutDurationInDays { get; set; } // Asgari teslim süresi (gün cinsinden)
    public int MaxCheckoutDurationInDays { get; set; } // Azami teslim süresi (gün cinsinden)
    public int CriticalLevelThreshold { get; set; } // Eser kritik seviyesi

    public bool NotifyOnBookOrBlogComment { get; set; } // Eser veya blog yorumu bildirimi açık mı?

    public int TopMembersReportLimit { get; set; } // En çok okuyan üyeler raporunda listelenecek maksimum üye sayısı
    public int TopBooksReportLimit { get; set; } // En çok okuyan eserler raporunda listelenecek maksimum eser sayısı
}
