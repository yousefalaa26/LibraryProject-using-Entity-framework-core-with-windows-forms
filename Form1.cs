//using LibraryProject.Entities;
using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        private LibraryContext context;

        public Form1()
        {
            InitializeComponent();
            context = new LibraryContext();
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
        private void loadBorrowers()
        {
            var Borroweres = context.Borrowers.ToList();
            dataGridView3.DataSource = Borroweres;
        }
        private void loadPublishers()
        {
            var Publishers = context.Publishers.ToList(); dataGridView4.DataSource = Publishers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadBooks();
            loadAuthors();
            loadBorrowers();
            loadPublishers();
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
                    BookEditionTb.Text = book.Edition;
                    BookYearTb.Text = book.YearOfPublication.ToString();
                    BookPriceTb.Text = book.Price.ToString();
                    BookCategoryIdTb.Text = book.CatId.ToString();
                    BookPublisherIdTb.Text = book.PubId.ToString();
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
                    Edition = BookEditionTb.Text,
                    YearOfPublication = DateOnly.Parse(BookYearTb.Text),
                    Price = int.Parse(BookPriceTb.Text),
                    CatId = int.Parse(BookCategoryIdTb.Text),
                    PubId = int.Parse(BookPublisherIdTb.Text)

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
                book.Edition = BookEditionTb.Text;
                book.YearOfPublication = DateOnly.Parse(BookYearTb.Text);
                book.Price = int.Parse(BookPriceTb.Text);
                book.CatId = int.Parse(BookCategoryIdTb.Text);
                book.PubId = int.Parse(BookPublisherIdTb.Text);

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
                SingleOrDefault(x => x.AuId == (int)dataGridView2.CurrentRow.Cells[0].Value);

            if (author != null)
            {
                AuthorIdTb.Text = author.AuId.ToString();
                AuthorFirstTb.Text = author.FirstName;
                AuthorMidTb.Text = author.MidName;
                AuthorLastTb.Text = author.LastName;
            }
        }

        private void AuthorAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author()
                {
                    AuId = int.Parse(AuthorIdTb.Text),
                    FirstName = AuthorFirstTb.Text,
                    MidName = AuthorMidTb.Text,
                    LastName = AuthorLastTb.Text
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
                    Single(x => x.AuId == (int)dataGridView2.CurrentRow.Cells[0].Value);

                author.AuId = int.Parse(AuthorIdTb.Text);
                author.FirstName = AuthorFirstTb.Text;
                author.MidName = AuthorMidTb.Text;
                author.LastName = AuthorLastTb.Text;


                context.SaveChanges();
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
                    Single(x => x.AuId == (int)dataGridView2.CurrentRow.Cells[0].Value);

                context.Authors.Remove(author);
                context.SaveChanges();

                loadAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing author: " + ex.Message);
            }
        }
        //---------------------------------------Borrowers---------------------------------------//
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            var borrower = context.Borrowers.
                SingleOrDefault(x => x.BrrId == (int)dataGridView3.CurrentRow.Cells[0].Value);

            if (borrower != null)
            {
                BorrowerIdTb.Text = borrower.BrrId.ToString();
                BorrowerNameTb.Text = borrower.BrrName;
                BorrowereAddressTb.Text = borrower.BrrAddress;
            }
        }

        private void BorrowereAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Borrower borrower = new Borrower()
                {
                    BrrId = int.Parse(BorrowerIdTb.Text),
                    BrrName = BorrowerNameTb.Text,
                    BrrAddress = BorrowereAddressTb.Text,
                };

                context.Borrowers.Add(borrower);
                context.SaveChanges();

                loadBorrowers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Borrower: " + ex.Message);
            }
        }

        private void BorrowereUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var borrowere = context.Borrowers.
                    Single(x => x.BrrId == (int)dataGridView3.CurrentRow.Cells[0].Value);

                borrowere.BrrId = int.Parse(BorrowerIdTb.Text);
                borrowere.BrrName = BorrowerNameTb.Text;
                borrowere.BrrAddress = BorrowereAddressTb.Text;

                context.SaveChanges();
                loadBorrowers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating borrower: " + ex.Message);
            }
        }

        private void BorrowereRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var borrower = context.Borrowers.
                    Single(x => x.BrrId == (int)dataGridView3.CurrentRow.Cells[0].Value);

                context.Borrowers.Remove(borrower);
                context.SaveChanges();

                loadBorrowers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing borrower: " + ex.Message);
            }
        }

        //--------------------------------------Publishers-----------------------------------//
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            var publisher = context.Publishers
                .SingleOrDefault(x => x.PubId == (int)dataGridView4.CurrentRow.Cells[0].Value);

            if (publisher != null)
            {
                PublisherIdTb.Text = publisher.PubId.ToString();
                PublisherNameTb.Text = publisher.PubName;
                PublisherAddressTb.Text = publisher.PubAddress;
            }
        }
        private void PublisherAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Publisher publisher = new Publisher()
                {
                    PubId = int.Parse(PublisherIdTb.Text),
                    PubName = PublisherNameTb.Text,
                    PubAddress = PublisherAddressTb.Text
                };

                context.Publishers.Add(publisher);
                context.SaveChanges();

                loadPublishers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding publisher: " + ex.Message);
            }
        }

        private void PublisherUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var publisher = context.Publishers.
                    Single(x => x.PubId == (int)dataGridView4.CurrentRow.Cells[0].Value);

                publisher.PubId = int.Parse(PublisherIdTb.Text);
                publisher.PubName = PublisherNameTb.Text;
                publisher.PubAddress = PublisherAddressTb.Text;

                context.SaveChanges();
                loadPublishers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating publisher: " + ex.Message);
            }
        }

        private void PublisherRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var publisher = context.Publishers.
                    Single(x => x.PubId == (int)dataGridView4.CurrentRow.Cells[0].Value);

                context.Publishers.Remove(publisher);
                context.SaveChanges();

                loadPublishers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing publisher: " + ex.Message);
            }
        }
    }
}
