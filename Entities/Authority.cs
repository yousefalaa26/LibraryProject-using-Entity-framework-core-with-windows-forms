using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Authority
{
    public int Id { get; set; }

    public int? AuthorId { get; set; }

    public int? Isbn { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Book? IsbnNavigation { get; set; }
}
