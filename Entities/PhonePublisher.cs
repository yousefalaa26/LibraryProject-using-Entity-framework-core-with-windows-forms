using System;
using System.Collections.Generic;

namespace LibraryProject.Entities;

public partial class PhonePublisher
{
    public int? PubId { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Publisher? Pub { get; set; }
}
