using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Copy
{
    public int CopyId { get; set; }

    public int? CopyNumber { get; set; }

    public string? Available { get; set; }

    public int? BorrowingPeriod { get; set; }

    public int? Isbn { get; set; }

    public virtual ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();

    public virtual Book? IsbnNavigation { get; set; }
}
