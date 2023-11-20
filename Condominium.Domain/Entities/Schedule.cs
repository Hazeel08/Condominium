using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Schedule
{
    public int Id { get; set; }

    public string StartTime { get; set; } = null!;

    public string EndTime { get; set; } = null!;

    public DateTime Date { get; set; }
}
