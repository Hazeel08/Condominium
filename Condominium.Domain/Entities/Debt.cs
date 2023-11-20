using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Debt
{
    public int Id { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public int StatusDebtId { get; set; }

    public int PlanCategoryId { get; set; }

    public virtual PlanCategory PlanCategory { get; set; } = null!;

    public virtual StatusDebt StatusDebt { get; set; } = null!;
}
