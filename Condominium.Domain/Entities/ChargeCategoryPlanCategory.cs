using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class ChargeCategoryPlanCategory
{
    public int ChargeCategoryId { get; set; }

    public int PlanCategoryId { get; set; }

    public virtual ChargeCategory ChargeCategory { get; set; } = null!;

    public virtual PlanCategory PlanCategory { get; set; } = null!;
}
