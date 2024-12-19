using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Author
{
    public int AuId { get; set; }

    public string? FirstName { get; set; }

    public string? MidName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Book> Isbns { get; set; } = new List<Book>();
}
