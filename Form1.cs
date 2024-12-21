using LibraryProject.Entities;
using LibraryProject;
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

        private void loadAll()
        {
            loadBooks(); loadAuthors(); loadPublishers(); loadCopies(); loadPublisherPhone();
            loadAuthorities(); loadBorrows(); loadBorrowers(); loadBorrowersPhone(); loadCategories();
        }
        private void loadBooks()
        {
            var books = context.Books.ToList();
            DataGridBooks.DataSource = books;

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
            var Publishers = context.Publishers.ToList();
            dataGridView4.DataSource = Publishers;
        }
        private void loadBorrows()
        {
            var borrows = context.Borrows.ToList();
            dataGridView5.DataSource = borrows;
        }
        private void loadCategories()
        {
            var categories = context.Categories.ToList();
            DataGridCategory.DataSource = categories;
        }
        private void loadAuthorities()
        {
            var authorities = context.Authorities.ToList();
            DataGridAuthorities.DataSource = authorities;
        }
        private void loadCopies()
        {
            var copies = context.Copies.ToList();
            DataGridCopies.DataSource = copies;
        }
        private void loadBorrowersPhone()
        {
            var borrowerPhone = context.PhoneBorrowers.ToList();
            DataGridBorrowersPhone.DataSource = borrowerPhone;
        }
        private void loadPublisherPhone()
        {
            var phones = context.PhonePublishers.ToList();
            DataGridPublisherPhone.DataSource = phones;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridBooks.CurrentRow != null)
            {
                var book = context.Books
                    .SingleOrDefault(x => x.Isbn == (int)DataGridBooks.CurrentRow.Cells[0].Value);

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
                loadAll();
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
                var book = context.Books.Single(x => x.Isbn == (int)DataGridBooks.CurrentRow.Cells[0].Value);

                book.Isbn = int.Parse(BookISBNTb.Text);
                book.Title = BookTitleTb.Text;
                book.Edition = BookEditionTb.Text;
                book.YearOfPublication = DateOnly.Parse(BookYearTb.Text);
                book.Price = int.Parse(BookPriceTb.Text);
                book.CatId = int.Parse(BookCategoryIdTb.Text);
                book.PubId = int.Parse(BookPublisherIdTb.Text);

                context.SaveChanges();
                loadAll();
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
                var book = context.Books.Single(x => x.Isbn == (int)DataGridBooks.CurrentRow.Cells[0].Value);

                context.Books.Remove(book);
                context.SaveChanges();
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing book: " + ex.Message);
            }
        }

        // ---------------------------------------Authorities--------------------------------------//

        /////////////////////////////////////still not finished //////////////////////////////////////
        private void DataGridAuthorities_SelectionChanged(object sender, EventArgs e)
        {

            int Cell1 = (int)DataGridAuthorities.CurrentRow.Cells[0].Value;
            int Cell2 = (int)DataGridAuthorities.CurrentRow.Cells[1].Value;

            var authorities = context.Authorities
            .SingleOrDefault(x => x.Author_ID == Cell1
            && x.ISBN == Cell2);

            if (authorities != null)
            {
                AuthoritiesIsbnTb.Text = authorities.ISBN.ToString();
                AuthoritiesAuthorIdTb.Text = authorities.Author_ID.ToString();
            }
        }

        private void AuthoritiesAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Authorities authorities = new Authorities()
                {
                    ISBN = int.Parse(AuthoritiesIsbnTb.Text),
                    Author_ID = int.Parse(AuthoritiesAuthorIdTb.Text)
                };

                context.Authorities.Add(authorities);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding authorities: " + ex.Message);
            }
        }

        private void AuthoritiesUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var authorities = context.Authorities
                .Single(x => x.ISBN == (int)DataGridAuthorities.CurrentRow.Cells[0].Value
                && x.Author_ID == (int)DataGridAuthorities.CurrentRow.Cells[1].Value);

                authorities.ISBN = int.Parse(AuthoritiesIsbnTb.Text);
                authorities.Author_ID = int.Parse(AuthoritiesAuthorIdTb.Text);

                context.SaveChanges();
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating authorities: " + ex.Message);
            }
        }

        private void AuthoritiesRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var authorities = context.Authorities
                .Single(x => x.ISBN == (int)DataGridAuthorities.CurrentRow.Cells[0].Value
                && x.Author_ID == (int)DataGridAuthorities.CurrentRow.Cells[1].Value);

                context.Authorities.Remove(authorities);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing authorities: " + ex.Message);
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

                loadAll();
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
                loadAll();
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

                loadAll();
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

                loadAll();
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
                loadAll();
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

                loadAll();
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

                loadAll();
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
                loadAll();
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

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing publisher: " + ex.Message);
            }
        }

        //-------------------------------------Borrows-------------------------------------//
        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            var borrow = context.Borrows
                .SingleOrDefault(x => x.Borrow_Id == (int)dataGridView5.CurrentRow.Cells[0].Value);

            if (borrow != null)
            {
                //BorrowIdTb.Text = borrow.Borrow_Id.ToString();
                BorrowDatePicker.Text = borrow.BorrowingDate.ToString();
                BorrowReturnPicker.Text = borrow.ReturnDate.ToString();
                BorrowBorrowerIdTb.Text = borrow.BorrowerId.ToString();
                BorrowCopyIdTb.Text = borrow.CopyId.ToString();
            }
        }

        private void BorrowsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Borrow borrow = new Borrow()
                {
                    //Borrow_Id = int.Parse(BorrowIdTb.Text),
                    BorrowingDate = DateOnly.Parse(BorrowDatePicker.Text),
                    ReturnDate = DateOnly.Parse(BorrowReturnPicker.Text),
                    BorrowerId = int.Parse(BorrowBorrowerIdTb.Text),
                    CopyId = int.Parse(BorrowCopyIdTb.Text)
                };

                context.Borrows.Add(borrow);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding borrow: " + ex.Message);
            }
        }

        private void BorrowsUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var borrow = context.Borrows.
                    Single(x => x.Borrow_Id == (int)dataGridView5.CurrentRow.Cells[0].Value);

                //borrow.Borrow_Id = int.Parse(BorrowIdTb.Text);
                borrow.BorrowingDate = DateOnly.Parse(BorrowDatePicker.Text);
                borrow.ReturnDate = DateOnly.Parse(BorrowReturnPicker.Text);
                borrow.BorrowerId = int.Parse(BorrowBorrowerIdTb.Text);
                borrow.CopyId = int.Parse(BorrowCopyIdTb.Text);

                context.SaveChanges();
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating borrow: " + ex.Message);
            }
        }

        private void BorrowsRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var borrow = context.Borrows.
                    Single(x => x.Borrow_Id == (int)dataGridView5.CurrentRow.Cells[0].Value);

                context.Borrows.Remove(borrow);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing borrow: " + ex.Message);
            }
        }

        //---------------------------------------Copies---------------------------------------//
        //////////////////////////////there is an error////////////////////////////////////////
        private void DataGridCopies_SelectionChanged(object sender, EventArgs e)
        {
            var copy = context.Copies.
                SingleOrDefault(x => x.CopyId == (int)DataGridCopies.CurrentRow.Cells[0].Value);

            if (copy != null)
            {
                if (copy.Available == "TRUE") CopiesAvailableCheckBox.Checked = true;
                else CopiesAvailableCheckBox.Checked = false;

                CopiesCopyIdTb.Text = copy.CopyId.ToString();
                CopiesCopyNumberTb.Text = copy.CopyNumber.ToString();
                CopiesPeriodTb.Text = copy.BorrowingPeriod.ToString();
                CopiesIsbnTb.Text = copy.Isbn.ToString();
            }
        }

        private void CopiesAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string flag;
                if (CopiesAvailableCheckBox.Checked) flag = "TRUE";
                else flag = "FALSE";


                Copy copy = new Copy()
                {
                    CopyId = int.Parse(CopiesCopyIdTb.Text),
                    CopyNumber = int.Parse(CopiesCopyNumberTb.Text),
                    Available = flag,
                    BorrowingPeriod = int.Parse(CopiesPeriodTb.Text),
                    Isbn = int.Parse(CopiesIsbnTb.Text)
                };

                context.Copies.Add(copy);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding copy: " + ex.Message);
            }
        }

        private void CopiesUpdateBtn_Click(object sender, EventArgs e)
        {
            string flag;
            try
            {
                var copy = context.Copies.
                    Single(x => x.CopyId == (int)DataGridCopies.CurrentRow.Cells[0].Value);

                if (CopiesAvailableCheckBox.Checked) flag = "TRUE";
                else flag = "FALSE";

                copy.CopyId = int.Parse(CopiesCopyIdTb.Text);
                copy.CopyNumber = int.Parse(CopiesCopyNumberTb.Text);
                copy.Available = flag;
                copy.BorrowingPeriod = int.Parse(CopiesPeriodTb.Text);
                copy.Isbn = int.Parse(CopiesCopyIdTb.Text);

                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating copy: " + ex.Message);
            }
        }

        private void CopiesRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var copy = context.Copies.
                    Single(x => x.CopyId == (int)DataGridCopies.CurrentRow.Cells[0].Value);

                context.Copies.Remove(copy);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing copy: " + ex.Message);
            }
        }

        //---------------------------------------Category--------------------------------------//
        private void DataGridCategory_SelectionChanged(object sender, EventArgs e)
        {

            var category = context.Categories
                .SingleOrDefault(x => x.CatId == (int)DataGridCategory.CurrentRow.Cells[0].Value);

            if (category != null)
            {
                CategoryIdTb.Text = category.CatId.ToString();
                CategoryNameTb.Text = category.CatName.ToString();
            }
        }

        private void CategoryAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category()
                {
                    CatId = int.Parse(CategoryIdTb.Text),
                    CatName = CategoryNameTb.Text
                };

                context.Categories.Add(category);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
            }
        }

        private void CategoryUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var category = context.Categories
                .Single(x => x.CatId == (int)DataGridCategory.CurrentRow.Cells[0].Value);

                category.CatId = int.Parse(CategoryIdTb.Text);
                category.CatName = CategoryNameTb.Text;

                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message);
            }
        }

        private void CategoryRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var category = context.Categories
                .SingleOrDefault(x => x.CatId == (int)DataGridCategory.CurrentRow.Cells[0].Value);

                context.Categories.Remove(category);

                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing category: " + ex.Message);
            }
        }

        //-------------------------------------BorrowerPhone----------------------------------//
        private void DataGridBorrowersPhone_SelectionChanged(object sender, EventArgs e)
        {
            var borrowerPhone = context.PhoneBorrowers
                .SingleOrDefault(x => x.BrrId == (int)DataGridBorrowersPhone.CurrentRow.Cells[0].Value);

            if (borrowerPhone != null)
            {
                BorrowerPhoneIdTb.Text = borrowerPhone.BrrId.ToString();
                BorrowerPhoneTb.Text = borrowerPhone.BrrPhone;
            }
        }

        private void BorrowerPhoneAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PhoneBorrower phoneBorrower = new PhoneBorrower()
                {
                    BrrId = int.Parse(BorrowerPhoneIdTb.Text),
                    BrrPhone = BorrowerPhoneTb.Text
                };

                context.PhoneBorrowers.Add(phoneBorrower);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding borrower phone: " + ex.Message);
            }
        }

        private void BorrowerPhoneUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var borrowerPhone = context.PhoneBorrowers
                .Single(x => x.BrrId == (int)DataGridBorrowersPhone.CurrentRow.Cells[0].Value);

                borrowerPhone.BrrId = int.Parse(BorrowerPhoneIdTb.Text);
                borrowerPhone.BrrPhone = BorrowerPhoneTb.Text;

                context.SaveChanges();
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating borrower phone: " + ex.Message);
            }
        }

        private void BorrowerPhoneRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var borrowerPhone = context.PhoneBorrowers
                .Single(x => x.BrrId == (int)DataGridBorrowersPhone.CurrentRow.Cells[0].Value);

                context.PhoneBorrowers.Remove(borrowerPhone);
                context.SaveChanges();
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Removing borrower phone: " + ex.Message);
            }
        }

        //------------------------------------------publisherPhone----------------------------------------//
        private void DataGridPublisherPhone_SelectionChanged(object sender, EventArgs e)
        {
            var publisherPhone = context.PhonePublishers
                .SingleOrDefault(x => x.PubId == (int)DataGridPublisherPhone.CurrentRow.Cells[0].Value);

            if (publisherPhone != null)
            {
                PublisherPhoneIdTb.Text = publisherPhone.PubId.ToString();
                PublisherPhoneTb.Text = publisherPhone.PhoneNumber;
            }
        }

        private void PublisherPhoneAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PhonePublisher phonePublisher = new PhonePublisher()
                {
                    PubId = int.Parse(PublisherPhoneIdTb.Text),
                    PhoneNumber = PublisherPhoneTb.Text
                };

                context.PhonePublishers.Add(phonePublisher);
                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding publisher phone: " + ex.Message);
            }
        }

        private void PublisherPhoneUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var publisherPhone = context.PhonePublishers
                .Single(x => x.PubId == (int)DataGridPublisherPhone.CurrentRow.Cells[0].Value);

                publisherPhone.PubId = int.Parse(PublisherPhoneIdTb.Text);
                publisherPhone.PhoneNumber = PublisherPhoneTb.Text;

                context.SaveChanges();

                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating publisher phone: " + ex.Message);
            }
        }

        private void PublisherPhoneRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var publisherPhone = context.PhonePublishers
                .Single(x => x.PubId == (int)DataGridPublisherPhone.CurrentRow.Cells[0].Value);

                context.PhonePublishers.Remove(publisherPhone);
                context.SaveChanges();
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Removing publisher phone: " + ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var borrowerWithBooks = from b in context.Borrowers join br in context.Borrows
                on b.BrrId equals br.BorrowerId 
                join c in context.Copies on br.CopyId equals c.CopyId 
                join bk in context.Books on c.Isbn equals bk.Isbn 
                join cat in context.Categories on bk.CatId equals cat.CatId 
                join auth in context.Authorities on bk.Isbn equals auth.ISBN
                join a in context.Authors on auth.Author_ID equals a.AuId
                where b.BrrId == int.Parse(searchTb.Text) select new
                {
                    BorrowerName = b.BrrName, BorrowerAddress = b.BrrAddress,
                    RentDate = br.BorrowingDate, ReturnDate = br.ReturnDate,
                    book = bk.Title , category = cat.CatName,
                    author = $"{a.FirstName} {a.LastName}"
                    
                };

            string message="Borrower information: ";

            foreach (var item in borrowerWithBooks)
            {
                message += $"\nBorrower: {item.BorrowerName}"; message += $"\nAddress: {item.BorrowerAddress}";
                message += $"\nRented book: {item.book} by {item.author}"; message += $"\nCategory: {item.category}";
                message += $"\nFrom: {item.RentDate} To: {item.ReturnDate}";
            }

            if (message == "Borrower information: ")
                message = "Customer have not rented a book";

            MessageBox.Show(message, "Borrower Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
