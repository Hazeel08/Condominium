using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class StatusResidence
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Residence> Residences { get; set; } = new List<Residence>();
}
