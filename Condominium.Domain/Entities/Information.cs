using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Information
{
    public int Id { get; set; }

    public string? Picture { get; set; }

    public string Description { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public DateTime Date { get; set; }

    public int InformationTypeId { get; set; }

    public int UserId { get; set; }

    public virtual InformationType InformationType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
