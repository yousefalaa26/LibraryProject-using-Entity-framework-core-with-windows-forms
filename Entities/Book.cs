using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Book
{
    public int Isbn { get; set; }

    public string Title { get; set; } = null!;

    public string? Edition { get; set; }

    public DateOnly? YearOfPublication { get; set; }

    public int? Price { get; set; }

    public int? CatId { get; set; }

    public int? PubId { get; set; }

    public virtual Category? Cat { get; set; }

    public virtual ICollection<Copy> Copies { get; set; } = new List<Copy>();

    public virtual Publisher? Pub { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
