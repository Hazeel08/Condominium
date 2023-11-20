using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Booking
{
    public int Id { get; set; }

    public int CommonAreaId { get; set; }

    public int UserId { get; set; }

    public int StatusBookingId { get; set; }

    public virtual StatusBooking StatusBooking { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
