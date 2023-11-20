using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities;

public partial class Status
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
