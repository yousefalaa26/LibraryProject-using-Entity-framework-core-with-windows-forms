using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Borrow
{
    public int Borrow_Id { get; set; }

    public DateOnly? BorrowingDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public int? BorrowerId { get; set; }

    public int? CopyId { get; set; }

    public virtual Borrower? Borrower { get; set; }

    public virtual Copy? Copy { get; set; }
}
