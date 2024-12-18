using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Borrow
{
    public int Borrowid { get; set; }

    public DateOnly? BorrowingDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public int? BorrowereId { get; set; }

    public int? CopyId { get; set; }

    public virtual Borrowere? Borrowere { get; set; }

    public virtual Copy? Copy { get; set; }
}
