using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Phone
{
    public string? Phonenumber { get; set; }

    public int? PubId { get; set; }

    public virtual Publisher? Pub { get; set; }
}
