namespace LibraryProject.Entities;
public class Authorities
{
    public int Author_ID { get; set; }
    public Author Author { get; set; }
    public int ISBN { get; set; }
    public Book Book { get; set; }
}