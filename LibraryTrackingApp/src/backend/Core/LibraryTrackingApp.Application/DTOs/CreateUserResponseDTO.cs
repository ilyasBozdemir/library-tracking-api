using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAccountingBE.Application.Features.DTOs.User;

public record CreateUserResponseDTO : BaseAuditableDTO<Guid>
{
    public bool Succeeded { get; set; }
    public string Message { get; set; }
}
