using System;
using System.Collections.Generic;
using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject;

public partial class LibraryProjectContext : DbContext
{
    public LibraryProjectContext()
    {
    }

    public LibraryProjectContext(DbContextOptions<LibraryProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Authority> Authorities { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Borrow> Borrows { get; set; }

    public virtual DbSet<Borrowere> Borroweres { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Copy> Copies { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Initial Catalog=libraryProject; Data Source=.; Integrated Security= SSPI; TrustServerCertificate= True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Author__3213E83FE9ED424C");

            entity.ToTable("Author");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastname");
        });

        modelBuilder.Entity<Authority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__authorit__3213E83F009DFD77");

            entity.ToTable("authorities");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.Author).WithMany(p => p.Authorities)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__authoriti__autho__412EB0B6");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.Authorities)
                .HasForeignKey(d => d.Isbn)
                .HasConstraintName("FK__authoritie__ISBN__4222D4EF");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Book__447D36EBA3FA1162");

            entity.ToTable("Book");

            entity.Property(e => e.Isbn)
                .ValueGeneratedNever()
                .HasColumnName("ISBN");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Edition).HasColumnName("edition");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Pubid).HasColumnName("pubid");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Yearofpublication).HasColumnName("yearofpublication");

            entity.HasOne(d => d.Cat).WithMany(p => p.Books)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK__Book__cat_id__3D5E1FD2");

            entity.HasOne(d => d.Pub).WithMany(p => p.Books)
                .HasForeignKey(d => d.Pubid)
                .HasConstraintName("FK__Book__pubid__3E52440B");
        });

        modelBuilder.Entity<Borrow>(entity =>
        {
            entity.HasKey(e => e.Borrowid).HasName("PK__borrow__739928BE34529F83");

            entity.ToTable("borrow");

            entity.Property(e => e.Borrowid)
                .ValueGeneratedNever()
                .HasColumnName("borrowid");
            entity.Property(e => e.BorrowereId).HasColumnName("borrowere_id");
            entity.Property(e => e.BorrowingDate).HasColumnName("borrowing_date");
            entity.Property(e => e.CopyId).HasColumnName("copy_id");
            entity.Property(e => e.ReturnDate).HasColumnName("return_date");

            entity.HasOne(d => d.Borrowere).WithMany(p => p.Borrows)
                .HasForeignKey(d => d.BorrowereId)
                .HasConstraintName("FK__borrow__borrower__49C3F6B7");

            entity.HasOne(d => d.Copy).WithMany(p => p.Borrows)
                .HasForeignKey(d => d.CopyId)
                .HasConstraintName("FK__borrow__copy_id__4AB81AF0");
        });

        modelBuilder.Entity<Borrowere>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__borrower__3213E83F35BFD814");

            entity.ToTable("borrowere");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__category__DD5DDDBDD69D0E00");

            entity.ToTable("category");

            entity.Property(e => e.CatId)
                .ValueGeneratedNever()
                .HasColumnName("cat_id");
            entity.Property(e => e.CatName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cat_name");
        });

        modelBuilder.Entity<Copy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__copy__3213E83F8117C582");

            entity.ToTable("copy");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Availability)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("availability");
            entity.Property(e => e.BorrowingPeriod).HasColumnName("borrowing_period");
            entity.Property(e => e.CopyNumber).HasColumnName("copy_number");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.Copies)
                .HasForeignKey(d => d.Isbn)
                .HasConstraintName("FK__copy__ISBN__44FF419A");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("phone");

            entity.Property(e => e.Phonenumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phonenumber");
            entity.Property(e => e.PubId).HasColumnName("pub_id");

            entity.HasOne(d => d.Pub).WithMany()
                .HasForeignKey(d => d.PubId)
                .HasConstraintName("FK__phone__pub_id__4CA06362");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__publishe__3213E83FC8D03A9B");

            entity.ToTable("publisher");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
