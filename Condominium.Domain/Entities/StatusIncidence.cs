using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class StatusIncidence
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Incidence> Incidences { get; set; } = new List<Incidence>();
}
