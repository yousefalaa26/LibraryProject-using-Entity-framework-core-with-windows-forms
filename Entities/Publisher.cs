using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Publisher
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
