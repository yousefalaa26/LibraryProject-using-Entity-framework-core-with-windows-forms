using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Borrower
{
    public int BrrId { get; set; }

    public string BrrName { get; set; } = null!;

    public string? BrrAddress { get; set; }

    public virtual ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
}
