using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class CommonAreaSchedule
{
    public int CommonAreaId { get; set; }

    public int ScheduleId { get; set; }

    public virtual CommonArea CommonArea { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
