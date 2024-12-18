using LibraryProject.Entities;

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

        //-----------------------------Books---------------------------------//

        private void loadBooks()
        {
            var books = context.Books.ToList();
            dataGridView1.DataSource = books;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadBooks();
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
    }
}
