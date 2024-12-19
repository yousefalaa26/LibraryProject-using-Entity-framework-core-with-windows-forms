using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Publisher
{
    public int PubId { get; set; }

    public string? PubName { get; set; }

    public string? PubAddress { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
