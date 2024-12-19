using System;
using System.Collections.Generic;
using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Borrow> Borrows { get; set; }

    public virtual DbSet<Borrower> Borrowers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Copy> Copies { get; set; }

    public virtual DbSet<PhoneBorrower> PhoneBorrowers { get; set; }

    public virtual DbSet<PhonePublisher> PhonePublishers { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Initial Catalog= Library; Data Source=.; Integrated Security=SSPI; TrustServerCertificate= True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuId).HasName("PK__Author__E26B4B8A6F5259F0");

            entity.ToTable("Author");

            entity.Property(e => e.AuId)
                .ValueGeneratedNever()
                .HasColumnName("Au_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MidName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mid_Name");

            entity.HasMany(d => d.Isbns).WithMany(p => p.Authors)
                .UsingEntity<Dictionary<string, object>>(
                    "Authority",
                    r => r.HasOne<Book>().WithMany()
                        .HasForeignKey("Isbn")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Authorities_Books"),
                    l => l.HasOne<Author>().WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Authorities_Author"),
                    j =>
                    {
                        j.HasKey("AuthorId", "Isbn").HasName("PK__Authorit__F1FE25B1490721F8");
                        j.ToTable("Authorities");
                        j.IndexerProperty<int>("AuthorId").HasColumnName("Author_ID");
                        j.IndexerProperty<int>("Isbn").HasColumnName("ISBN");
                    });
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__books__447D36EB91D2A281");

            entity.ToTable("books");

            entity.Property(e => e.Isbn)
                .ValueGeneratedNever()
                .HasColumnName("ISBN");
            entity.Property(e => e.CatId).HasColumnName("Cat_ID");
            entity.Property(e => e.Edition)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PubId).HasColumnName("Pub_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.YearOfPublication).HasColumnName("Year_of_publication");

            entity.HasOne(d => d.Cat).WithMany(p => p.Books)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_books_Category");

            entity.HasOne(d => d.Pub).WithMany(p => p.Books)
                .HasForeignKey(d => d.PubId)
                .HasConstraintName("FK_books_Publisher");
        });

        modelBuilder.Entity<Borrow>(entity =>
        {
            entity.HasKey(e => e.BorrowId).HasName("PK__Borrow__B7FA24ECCB41D5E8");

            entity.ToTable("Borrow");

            entity.Property(e => e.BorrowId)
                .ValueGeneratedNever()
                .HasColumnName("Borrow_ID");
            entity.Property(e => e.BorrowerId).HasColumnName("Borrower_ID");
            entity.Property(e => e.BorrowingDate).HasColumnName("borrowing_date");
            entity.Property(e => e.CopyId).HasColumnName("Copy_ID");
            entity.Property(e => e.ReturnDate).HasColumnName("return_date");

            entity.HasOne(d => d.Borrower).WithMany(p => p.Borrows)
                .HasForeignKey(d => d.BorrowerId)
                .HasConstraintName("FK_Borrow_Borrower");

            entity.HasOne(d => d.Copy).WithMany(p => p.Borrows)
                .HasForeignKey(d => d.CopyId)
                .HasConstraintName("FK_Borrow_Copies");
        });

        modelBuilder.Entity<Borrower>(entity =>
        {
            entity.HasKey(e => e.BrrId).HasName("PK__Borrower__D25014B9674E4EC5");

            entity.ToTable("Borrower");

            entity.Property(e => e.BrrId)
                .ValueGeneratedNever()
                .HasColumnName("Brr_ID");
            entity.Property(e => e.BrrAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Brr_address");
            entity.Property(e => e.BrrName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Brr_Name");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__Category__26E351208052FA6E");

            entity.ToTable("Category");

            entity.Property(e => e.CatId)
                .ValueGeneratedNever()
                .HasColumnName("Cat_ID");
            entity.Property(e => e.CatName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Cat_Name");
        });

        modelBuilder.Entity<Copy>(entity =>
        {
            entity.HasKey(e => e.CopyId).HasName("PK__Copies__2980667D54F7BB77");

            entity.Property(e => e.CopyId)
                .ValueGeneratedNever()
                .HasColumnName("Copy_ID");
            entity.Property(e => e.Available)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("available");
            entity.Property(e => e.BorrowingPeriod).HasColumnName("Borrowing_Period");
            entity.Property(e => e.CopyNumber).HasColumnName("Copy_number");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.Copies)
                .HasForeignKey(d => d.Isbn)
                .HasConstraintName("FK_Copies_Books");
        });

        modelBuilder.Entity<PhoneBorrower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Phone_Borrower");

            entity.Property(e => e.BrrId).HasColumnName("Brr_ID");
            entity.Property(e => e.BrrPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Brr_Phone");

            entity.HasOne(d => d.Brr).WithMany()
                .HasForeignKey(d => d.BrrId)
                .HasConstraintName("FK_Phone_Borrower");
        });

        modelBuilder.Entity<PhonePublisher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Phone_Publisher");

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.PubId).HasColumnName("Pub_ID");

            entity.HasOne(d => d.Pub).WithMany()
                .HasForeignKey(d => d.PubId)
                .HasConstraintName("FK_Phone_Publisher");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PubId).HasName("PK__Publishe__A9E4C647C25AE916");

            entity.ToTable("Publisher");

            entity.Property(e => e.PubId)
                .ValueGeneratedNever()
                .HasColumnName("Pub_ID");
            entity.Property(e => e.PubAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pub_Address");
            entity.Property(e => e.PubName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pub_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
