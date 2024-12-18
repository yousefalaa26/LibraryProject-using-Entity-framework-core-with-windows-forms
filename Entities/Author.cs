using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Author
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Authority> Authorities { get; set; } = new List<Authority>();
}
