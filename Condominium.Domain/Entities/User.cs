using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string FirstLastName { get; set; } = null!;

    public string SecondLastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Incidence> Incidences { get; set; } = new List<Incidence>();

    public virtual ICollection<Information> Information { get; set; } = new List<Information>();

    public virtual ICollection<Residence> Residences { get; set; } = new List<Residence>();

    public virtual Role Role { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
