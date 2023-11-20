using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class CommonArea
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Picture { get; set; }
}
