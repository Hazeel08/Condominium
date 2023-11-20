using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class ChargeCategory
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }
}
