using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Incidence
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int StatusIncidenceId { get; set; }

    public int UserId { get; set; }

    public virtual StatusIncidence StatusIncidence { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
