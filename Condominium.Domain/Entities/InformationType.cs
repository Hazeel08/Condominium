using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class InformationType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Information> Information { get; set; } = new List<Information>();
}
