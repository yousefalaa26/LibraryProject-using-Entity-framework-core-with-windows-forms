using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Borrowere
{
    public int Id { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
}
