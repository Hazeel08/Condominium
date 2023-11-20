using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class CommonAreaBooking
{
    public int CommonAreaId { get; set; }

    public int BookingId { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual CommonArea CommonArea { get; set; } = null!;
}
