using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Residence
{
    public int Id { get; set; }

    public string? ResidenceNumber { get; set; }

    public int PersonQuantity { get; set; }

    public int CarQuantity { get; set; }

    public int BedroomQuantity { get; set; }

    public int BathroomQuantity { get; set; }

    public string StartYear { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Picture { get; set; }

    public int UserId { get; set; }

    public int StatusResidenceId { get; set; }

    public virtual StatusResidence StatusResidence { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
