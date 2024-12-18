namespace LibraryProject.Entities;

public partial class Book
{
    public int Isbn { get; set; }

    public string? Title { get; set; }

    public int? Edition { get; set; }

    public DateOnly? Yearofpublication { get; set; }

    public int? Price { get; set; }

    public int? CatId { get; set; }

    public int? Pubid { get; set; }

    public virtual ICollection<Authority> Authorities { get; set; } = new List<Authority>();

    public virtual Category? Cat { get; set; }

    public virtual ICollection<Copy> Copies { get; set; } = new List<Copy>();

    public virtual Publisher? Pub { get; set; }
}
