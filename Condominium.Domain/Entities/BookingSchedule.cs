using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class BookingSchedule
{
    public int BookingId { get; set; }

    public int ScheduleId { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
