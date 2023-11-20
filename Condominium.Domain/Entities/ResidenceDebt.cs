using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class ResidenceDebt
{
    public int ResidenceId { get; set; }

    public int DebtId { get; set; }

    public virtual Debt Debt { get; set; } = null!;

    public virtual Residence Residence { get; set; } = null!;
}
