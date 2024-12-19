using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class PhoneBorrower
{
    public string? BrrPhone { get; set; }

    public int? BrrId { get; set; }

    public virtual Borrower? Brr { get; set; }
}
