using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class StatusBooking
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
