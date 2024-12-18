using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        private LibraryProjectContext context;

        public Form1()
        {
            InitializeComponent();
            context = new LibraryProjectContext();
        }

        //------------------------------------------Books-------------------------------------------//

        private void loadBooks()
        {
            var books = context.Books.ToList();
            dataGridView1.DataSource = books;

        }
        private void loadAuthors()
        {
            var authors = context.Authors.ToList();
            dataGridView2.DataSource = authors;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadBooks();
            loadAuthors();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var book = context.Books
                    .SingleOrDefault(x => x.Isbn == (int)dataGridView1.CurrentRow.Cells[0].Value);

                if (book != null)
                {
                    BookISBNTb.Text = book.Isbn.ToString();
                    BookTitleTb.Text = book.Title;
                    BookEditionTb.Text = book.Edition.ToString();
                    BookYearTb.Text = book.Yearofpublication.ToString();
                    BookPriceTb.Text = book.Price.ToString();
                    BookCategoryIdTb.Text = book.CatId.ToString();
                    BookPublisherIdTb.Text = book.Pubid.ToString();
                }
            }
        }

        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book()
                {
                    Isbn = int.Parse(BookISBNTb.Text),
                    Title = BookTitleTb.Text,
                    Edition = int.Parse(BookEditionTb.Text),
                    Yearofpublication = DateOnly.Parse(BookYearTb.Text),
                    Price = int.Parse(BookPriceTb.Text),
                    CatId = int.Parse(BookCategoryIdTb.Text),
                    Pubid = int.Parse(BookPublisherIdTb.Text)

                };

                context.Books.Add(book);
                context.SaveChanges();
                loadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        private void BookUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var book = context.Books.Single(x => x.Isbn == (int)dataGridView1.CurrentRow.Cells[0].Value);

                book.Isbn = int.Parse(BookISBNTb.Text);
                book.Title = BookTitleTb.Text;
                book.Edition = int.Parse(BookEditionTb.Text);
                book.Yearofpublication = DateOnly.Parse(BookYearTb.Text);
                book.Price = int.Parse(BookPriceTb.Text);
                book.CatId = int.Parse(BookCategoryIdTb.Text);
                book.Pubid = int.Parse(BookPublisherIdTb.Text);

                context.SaveChanges();
                loadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message);
            }
        }

        private void BookRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var book = context.Books.Single(x => x.Isbn == (int)dataGridView1.CurrentRow.Cells[0].Value);

                context.Books.Remove(book);
                context.SaveChanges();
                loadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing book: " + ex.Message);
            }
        }
        //-------------------------------------Authors----------------------------------------//

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            var author = context.Authors.
                SingleOrDefault(x => x.Id == (int)dataGridView2.CurrentRow.Cells[0].Value);

            if (author != null)
            {
                AuthorIdTb.Text = author.Id.ToString();
                AuthorFirstTb.Text = author.Firstname;
                AuthorLastTb.Text = author.Lastname;
                AuthorEmailTb.Text = author.Email;
            }
        }

        private void AuthorAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author()
                {
                    Id = int.Parse(AuthorIdTb.Text),
                    Firstname = AuthorFirstTb.Text,
                    Lastname = AuthorLastTb.Text,
                    Email = AuthorEmailTb.Text,
                };

                context.Authors.Add(author);
                context.SaveChanges();

                loadAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding author: " + ex.Message);
            }
        }

        private void AuthorUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var author = context.Authors.
                    Single(x => x.Id == (int)dataGridView2.CurrentRow.Cells[0].Value);

                author.Id = int.Parse(AuthorIdTb.Text);
                author.Firstname = AuthorFirstTb.Text;
                author.Lastname = AuthorLastTb.Text;
                author.Email = AuthorEmailTb.Text;

                loadAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Editing author: " + ex.Message);
            }
        }

        private void AuthorRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var author = context.Authors.
                    Single(x => x.Id == (int)dataGridView2.CurrentRow.Cells[0].Value);

                context.Authors.Remove(author);
                context.SaveChanges();

                loadAuthors();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error removing author: " + ex.Message);
            }
        }
    }
}
