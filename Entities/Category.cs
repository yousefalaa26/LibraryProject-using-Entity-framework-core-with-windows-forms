﻿using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class Category
{
    public int CatId { get; set; }

    public string CatName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
