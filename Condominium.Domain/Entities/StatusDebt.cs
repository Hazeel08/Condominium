using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class StatusDebt
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();
}
