namespace LibraryProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BookAddBtn = new Button();
            BookUpdateBtn = new Button();
            BookRemoveBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BookYearTb = new DateTimePicker();
            BookPublisherIdTb = new TextBox();
            BookCategoryIdTb = new TextBox();
            BookPriceTb = new TextBox();
            BookEditionTb = new TextBox();
            BookTitleTb = new TextBox();
            BookISBNTb = new TextBox();
            DataGridBooks = new DataGridView();
            bookBindingSource = new BindingSource(components);
            tabPage4 = new TabPage();
            AuthoritiesRemoveBtn = new Button();
            AuthoritiesUpdateBtn = new Button();
            label24 = new Label();
            label23 = new Label();
            AuthoritiesAddBtn = new Button();
            AuthoritiesIsbnTb = new TextBox();
            AuthoritiesAuthorIdTb = new TextBox();
            DataGridAuthorities = new DataGridView();
            authorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            authoritiesBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            AuthorRemoveBtn = new Button();
            AuthorUpdateBtn = new Button();
            AuthorAddBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            AuthorMidTb = new TextBox();
            AuthorLastTb = new TextBox();
            AuthorFirstTb = new TextBox();
            AuthorIdTb = new TextBox();
            dataGridView2 = new DataGridView();
            authorBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            BorrowereRemoveBtn = new Button();
            BorrowereUpdateBtn = new Button();
            BorrowereAddBtn = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            BorrowereAddressTb = new TextBox();
            BorrowerNameTb = new TextBox();
            BorrowerIdTb = new TextBox();
            dataGridView3 = new DataGridView();
            borrowerBindingSource = new BindingSource(components);
            tabPage7 = new TabPage();
            PublisherRemoveBtn = new Button();
            PublisherUpdateBtn = new Button();
            PublisherAddBtn = new Button();
            label17 = new Label();
            label13 = new Label();
            label12 = new Label();
            PublisherAddressTb = new TextBox();
            PublisherNameTb = new TextBox();
            PublisherIdTb = new TextBox();
            dataGridView4 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            pubNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publisherBindingSource = new BindingSource(components);
            tabPage5 = new TabPage();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            BorrowsRemoveBtn = new Button();
            BorrowsUpdateBtn = new Button();
            BorrowsAddBtn = new Button();
            BorrowReturnPicker = new DateTimePicker();
            BorrowDatePicker = new DateTimePicker();
            BorrowCopyIdTb = new TextBox();
            BorrowBorrowerIdTb = new TextBox();
            dataGridView5 = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            borrowingDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            copyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowBindingSource = new BindingSource(components);
            tabPage6 = new TabPage();
            label28 = new Label();
            label27 = new Label();
            label25 = new Label();
            label18 = new Label();
            CopiesRemoveBtn = new Button();
            CopiesUpdateBtn = new Button();
            CopiesAddBtn = new Button();
            CopiesAvailableCheckBox = new CheckBox();
            CopiesIsbnTb = new TextBox();
            CopiesPeriodTb = new TextBox();
            CopiesCopyNumberTb = new TextBox();
            CopiesCopyIdTb = new TextBox();
            DataGridCopies = new DataGridView();
            copyIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            copyNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowingPeriodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isbnDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            copyBindingSource = new BindingSource(components);
            tabPage8 = new TabPage();
            CategoryRemoveBtn = new Button();
            CategoryUpdateBtn = new Button();
            label29 = new Label();
            CategoryNameTb = new TextBox();
            CategoryIdTb = new TextBox();
            CategoryAddBtn = new Button();
            label26 = new Label();
            DataGridCategory = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            catNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            tabPage9 = new TabPage();
            label31 = new Label();
            label30 = new Label();
            BorrowerPhoneRemoveBtn = new Button();
            BorrowerPhoneUpdateBtn = new Button();
            BorrowerPhoneAddBtn = new Button();
            BorrowerPhoneTb = new TextBox();
            BorrowerPhoneIdTb = new TextBox();
            DataGridBorrowersPhone = new DataGridView();
            phoneBorrowerBindingSource = new BindingSource(components);
            tabPage10 = new TabPage();
            PublisherPhoneRemoveBtn = new Button();
            PublisherPhoneUpdateBtn = new Button();
            PublisherPhoneAddBtn = new Button();
            label33 = new Label();
            label32 = new Label();
            PublisherPhoneTb = new TextBox();
            PublisherPhoneIdTb = new TextBox();
            DataGridPublisherPhone = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            phonePublisherBindingSource = new BindingSource(components);
            brrIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            brrPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brrIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brrNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brrAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            auIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            midNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridAuthorities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authoritiesBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowerBindingSource).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)publisherBindingSource).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowBindingSource).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridCopies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)copyBindingSource).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridBorrowersPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneBorrowerBindingSource).BeginInit();
            tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridPublisherPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phonePublisherBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Controls.Add(tabPage10);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1162, 683);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BookAddBtn);
            tabPage1.Controls.Add(BookUpdateBtn);
            tabPage1.Controls.Add(BookRemoveBtn);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(BookYearTb);
            tabPage1.Controls.Add(BookPublisherIdTb);
            tabPage1.Controls.Add(BookCategoryIdTb);
            tabPage1.Controls.Add(BookPriceTb);
            tabPage1.Controls.Add(BookEditionTb);
            tabPage1.Controls.Add(BookTitleTb);
            tabPage1.Controls.Add(BookISBNTb);
            tabPage1.Controls.Add(DataGridBooks);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1154, 650);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BookAddBtn
            // 
            BookAddBtn.Location = new Point(909, 483);
            BookAddBtn.Name = "BookAddBtn";
            BookAddBtn.Size = new Size(196, 39);
            BookAddBtn.TabIndex = 20;
            BookAddBtn.Text = "Add";
            BookAddBtn.UseVisualStyleBackColor = true;
            BookAddBtn.Click += BookAddBtn_Click;
            // 
            // BookUpdateBtn
            // 
            BookUpdateBtn.Location = new Point(909, 539);
            BookUpdateBtn.Name = "BookUpdateBtn";
            BookUpdateBtn.Size = new Size(196, 39);
            BookUpdateBtn.TabIndex = 19;
            BookUpdateBtn.Text = "Update";
            BookUpdateBtn.UseVisualStyleBackColor = true;
            BookUpdateBtn.Click += BookUpdateBtn_Click;
            // 
            // BookRemoveBtn
            // 
            BookRemoveBtn.Location = new Point(909, 595);
            BookRemoveBtn.Name = "BookRemoveBtn";
            BookRemoveBtn.Size = new Size(196, 39);
            BookRemoveBtn.TabIndex = 18;
            BookRemoveBtn.Text = "Remove";
            BookRemoveBtn.UseVisualStyleBackColor = true;
            BookRemoveBtn.Click += BookRemoveBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(866, 435);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 17;
            label7.Text = "Publisher Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(866, 370);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 16;
            label6.Text = "Category Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(878, 306);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 15;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(878, 242);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 14;
            label4.Text = "Publication year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(878, 182);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 13;
            label3.Text = "Edition";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(890, 113);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 12;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(878, 46);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 11;
            label1.Text = "ISBN";
            // 
            // BookYearTb
            // 
            BookYearTb.Format = DateTimePickerFormat.Short;
            BookYearTb.Location = new Point(1011, 237);
            BookYearTb.Name = "BookYearTb";
            BookYearTb.Size = new Size(123, 27);
            BookYearTb.TabIndex = 10;
            // 
            // BookPublisherIdTb
            // 
            BookPublisherIdTb.Location = new Point(951, 432);
            BookPublisherIdTb.Name = "BookPublisherIdTb";
            BookPublisherIdTb.Size = new Size(183, 27);
            BookPublisherIdTb.TabIndex = 9;
            // 
            // BookCategoryIdTb
            // 
            BookCategoryIdTb.Location = new Point(951, 367);
            BookCategoryIdTb.Name = "BookCategoryIdTb";
            BookCategoryIdTb.Size = new Size(183, 27);
            BookCategoryIdTb.TabIndex = 8;
            // 
            // BookPriceTb
            // 
            BookPriceTb.Location = new Point(951, 299);
            BookPriceTb.Name = "BookPriceTb";
            BookPriceTb.Size = new Size(183, 27);
            BookPriceTb.TabIndex = 7;
            // 
            // BookEditionTb
            // 
            BookEditionTb.Location = new Point(951, 175);
            BookEditionTb.Name = "BookEditionTb";
            BookEditionTb.Size = new Size(183, 27);
            BookEditionTb.TabIndex = 6;
            // 
            // BookTitleTb
            // 
            BookTitleTb.Location = new Point(951, 106);
            BookTitleTb.Name = "BookTitleTb";
            BookTitleTb.Size = new Size(183, 27);
            BookTitleTb.TabIndex = 5;
            // 
            // BookISBNTb
            // 
            BookISBNTb.Location = new Point(951, 43);
            BookISBNTb.Name = "BookISBNTb";
            BookISBNTb.Size = new Size(183, 27);
            BookISBNTb.TabIndex = 4;
            // 
            // DataGridBooks
            // 
            DataGridBooks.AutoGenerateColumns = false;
            DataGridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBooks.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            DataGridBooks.DataSource = bookBindingSource;
            DataGridBooks.Dock = DockStyle.Left;
            DataGridBooks.Location = new Point(3, 3);
            DataGridBooks.Name = "DataGridBooks";
            DataGridBooks.RowHeadersWidth = 51;
            DataGridBooks.Size = new Size(833, 644);
            DataGridBooks.TabIndex = 0;
            DataGridBooks.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Entities.Book);
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(AuthoritiesRemoveBtn);
            tabPage4.Controls.Add(AuthoritiesUpdateBtn);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(AuthoritiesAddBtn);
            tabPage4.Controls.Add(AuthoritiesIsbnTb);
            tabPage4.Controls.Add(AuthoritiesAuthorIdTb);
            tabPage4.Controls.Add(DataGridAuthorities);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1154, 650);
            tabPage4.TabIndex = 10;
            tabPage4.Text = "Authorities";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // AuthoritiesRemoveBtn
            // 
            AuthoritiesRemoveBtn.Location = new Point(593, 500);
            AuthoritiesRemoveBtn.Name = "AuthoritiesRemoveBtn";
            AuthoritiesRemoveBtn.Size = new Size(247, 45);
            AuthoritiesRemoveBtn.TabIndex = 7;
            AuthoritiesRemoveBtn.Text = "Remove";
            AuthoritiesRemoveBtn.UseVisualStyleBackColor = true;
            AuthoritiesRemoveBtn.Click += AuthoritiesRemoveBtn_Click;
            // 
            // AuthoritiesUpdateBtn
            // 
            AuthoritiesUpdateBtn.Location = new Point(593, 416);
            AuthoritiesUpdateBtn.Name = "AuthoritiesUpdateBtn";
            AuthoritiesUpdateBtn.Size = new Size(247, 45);
            AuthoritiesUpdateBtn.TabIndex = 6;
            AuthoritiesUpdateBtn.Text = "Update";
            AuthoritiesUpdateBtn.UseVisualStyleBackColor = true;
            AuthoritiesUpdateBtn.Click += AuthoritiesUpdateBtn_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(663, 189);
            label24.Name = "label24";
            label24.Size = new Size(36, 20);
            label24.TabIndex = 5;
            label24.Text = "Isbn";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(635, 116);
            label23.Name = "label23";
            label23.Size = new Size(71, 20);
            label23.TabIndex = 4;
            label23.Text = "Author Id";
            // 
            // AuthoritiesAddBtn
            // 
            AuthoritiesAddBtn.Location = new Point(593, 338);
            AuthoritiesAddBtn.Name = "AuthoritiesAddBtn";
            AuthoritiesAddBtn.Size = new Size(247, 45);
            AuthoritiesAddBtn.TabIndex = 3;
            AuthoritiesAddBtn.Text = "Add";
            AuthoritiesAddBtn.UseVisualStyleBackColor = true;
            AuthoritiesAddBtn.Click += AuthoritiesAddBtn_Click;
            // 
            // AuthoritiesIsbnTb
            // 
            AuthoritiesIsbnTb.Location = new Point(742, 186);
            AuthoritiesIsbnTb.Name = "AuthoritiesIsbnTb";
            AuthoritiesIsbnTb.Size = new Size(244, 27);
            AuthoritiesIsbnTb.TabIndex = 2;
            // 
            // AuthoritiesAuthorIdTb
            // 
            AuthoritiesAuthorIdTb.Location = new Point(742, 113);
            AuthoritiesAuthorIdTb.Name = "AuthoritiesAuthorIdTb";
            AuthoritiesAuthorIdTb.Size = new Size(244, 27);
            AuthoritiesAuthorIdTb.TabIndex = 1;
            // 
            // DataGridAuthorities
            // 
            DataGridAuthorities.AutoGenerateColumns = false;
            DataGridAuthorities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridAuthorities.Columns.AddRange(new DataGridViewColumn[] { authorIDDataGridViewTextBoxColumn, dataGridViewTextBoxColumn9 });
            DataGridAuthorities.DataSource = authoritiesBindingSource;
            DataGridAuthorities.Dock = DockStyle.Left;
            DataGridAuthorities.Location = new Point(0, 0);
            DataGridAuthorities.Name = "DataGridAuthorities";
            DataGridAuthorities.RowHeadersWidth = 51;
            DataGridAuthorities.Size = new Size(304, 650);
            DataGridAuthorities.TabIndex = 0;
            DataGridAuthorities.SelectionChanged += DataGridAuthorities_SelectionChanged;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            authorIDDataGridViewTextBoxColumn.DataPropertyName = "Author_ID";
            authorIDDataGridViewTextBoxColumn.HeaderText = "Author_ID";
            authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "ISBN";
            dataGridViewTextBoxColumn9.HeaderText = "ISBN";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // authoritiesBindingSource
            // 
            authoritiesBindingSource.DataSource = typeof(Entities.Authorities);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AuthorRemoveBtn);
            tabPage2.Controls.Add(AuthorUpdateBtn);
            tabPage2.Controls.Add(AuthorAddBtn);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(AuthorMidTb);
            tabPage2.Controls.Add(AuthorLastTb);
            tabPage2.Controls.Add(AuthorFirstTb);
            tabPage2.Controls.Add(AuthorIdTb);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1154, 650);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Authors";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AuthorRemoveBtn
            // 
            AuthorRemoveBtn.Location = new Point(782, 558);
            AuthorRemoveBtn.Name = "AuthorRemoveBtn";
            AuthorRemoveBtn.Size = new Size(198, 37);
            AuthorRemoveBtn.TabIndex = 11;
            AuthorRemoveBtn.Text = "Remove";
            AuthorRemoveBtn.UseVisualStyleBackColor = true;
            AuthorRemoveBtn.Click += AuthorRemoveBtn_Click;
            // 
            // AuthorUpdateBtn
            // 
            AuthorUpdateBtn.Location = new Point(782, 483);
            AuthorUpdateBtn.Name = "AuthorUpdateBtn";
            AuthorUpdateBtn.Size = new Size(198, 37);
            AuthorUpdateBtn.TabIndex = 10;
            AuthorUpdateBtn.Text = "Update";
            AuthorUpdateBtn.UseVisualStyleBackColor = true;
            AuthorUpdateBtn.Click += AuthorUpdateBtn_Click;
            // 
            // AuthorAddBtn
            // 
            AuthorAddBtn.Location = new Point(782, 413);
            AuthorAddBtn.Name = "AuthorAddBtn";
            AuthorAddBtn.Size = new Size(198, 37);
            AuthorAddBtn.TabIndex = 9;
            AuthorAddBtn.Text = "Add";
            AuthorAddBtn.UseVisualStyleBackColor = true;
            AuthorAddBtn.Click += AuthorAddBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(766, 224);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 8;
            label11.Text = "Mid name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(766, 292);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 7;
            label10.Text = "Last name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(765, 143);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 6;
            label9.Text = "First name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(782, 70);
            label8.Name = "label8";
            label8.Size = new Size(22, 20);
            label8.TabIndex = 5;
            label8.Text = "Id";
            // 
            // AuthorMidTb
            // 
            AuthorMidTb.Location = new Point(873, 217);
            AuthorMidTb.Name = "AuthorMidTb";
            AuthorMidTb.Size = new Size(218, 27);
            AuthorMidTb.TabIndex = 4;
            // 
            // AuthorLastTb
            // 
            AuthorLastTb.Location = new Point(873, 285);
            AuthorLastTb.Name = "AuthorLastTb";
            AuthorLastTb.Size = new Size(218, 27);
            AuthorLastTb.TabIndex = 3;
            // 
            // AuthorFirstTb
            // 
            AuthorFirstTb.Location = new Point(873, 140);
            AuthorFirstTb.Name = "AuthorFirstTb";
            AuthorFirstTb.Size = new Size(218, 27);
            AuthorFirstTb.TabIndex = 2;
            // 
            // AuthorIdTb
            // 
            AuthorIdTb.Location = new Point(873, 63);
            AuthorIdTb.Name = "AuthorIdTb";
            AuthorIdTb.Size = new Size(218, 27);
            AuthorIdTb.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { auIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, midNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            dataGridView2.DataSource = authorBindingSource;
            dataGridView2.Dock = DockStyle.Left;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(630, 644);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Entities.Author);
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BorrowereRemoveBtn);
            tabPage3.Controls.Add(BorrowereUpdateBtn);
            tabPage3.Controls.Add(BorrowereAddBtn);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(BorrowereAddressTb);
            tabPage3.Controls.Add(BorrowerNameTb);
            tabPage3.Controls.Add(BorrowerIdTb);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1154, 650);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Borrowers";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BorrowereRemoveBtn
            // 
            BorrowereRemoveBtn.Location = new Point(726, 554);
            BorrowereRemoveBtn.Name = "BorrowereRemoveBtn";
            BorrowereRemoveBtn.Size = new Size(227, 46);
            BorrowereRemoveBtn.TabIndex = 13;
            BorrowereRemoveBtn.Text = "Remove";
            BorrowereRemoveBtn.UseVisualStyleBackColor = true;
            BorrowereRemoveBtn.Click += BorrowereRemoveBtn_Click;
            // 
            // BorrowereUpdateBtn
            // 
            BorrowereUpdateBtn.Location = new Point(726, 484);
            BorrowereUpdateBtn.Name = "BorrowereUpdateBtn";
            BorrowereUpdateBtn.Size = new Size(227, 46);
            BorrowereUpdateBtn.TabIndex = 12;
            BorrowereUpdateBtn.Text = "Update";
            BorrowereUpdateBtn.UseVisualStyleBackColor = true;
            BorrowereUpdateBtn.Click += BorrowereUpdateBtn_Click;
            // 
            // BorrowereAddBtn
            // 
            BorrowereAddBtn.Location = new Point(726, 416);
            BorrowereAddBtn.Name = "BorrowereAddBtn";
            BorrowereAddBtn.Size = new Size(227, 46);
            BorrowereAddBtn.TabIndex = 11;
            BorrowereAddBtn.Text = "Add";
            BorrowereAddBtn.UseVisualStyleBackColor = true;
            BorrowereAddBtn.Click += BorrowereAddBtn_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(699, 316);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 10;
            label16.Text = "Address";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(699, 230);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 9;
            label15.Text = "Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(712, 144);
            label14.Name = "label14";
            label14.Size = new Size(22, 20);
            label14.TabIndex = 8;
            label14.Text = "Id";
            // 
            // BorrowereAddressTb
            // 
            BorrowereAddressTb.Location = new Point(778, 309);
            BorrowereAddressTb.Name = "BorrowereAddressTb";
            BorrowereAddressTb.Size = new Size(222, 27);
            BorrowereAddressTb.TabIndex = 5;
            // 
            // BorrowerNameTb
            // 
            BorrowerNameTb.Location = new Point(778, 223);
            BorrowerNameTb.Name = "BorrowerNameTb";
            BorrowerNameTb.Size = new Size(222, 27);
            BorrowerNameTb.TabIndex = 4;
            // 
            // BorrowerIdTb
            // 
            BorrowerIdTb.Location = new Point(778, 137);
            BorrowerIdTb.Name = "BorrowerIdTb";
            BorrowerIdTb.Size = new Size(222, 27);
            BorrowerIdTb.TabIndex = 3;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { brrIdDataGridViewTextBoxColumn, brrNameDataGridViewTextBoxColumn, brrAddressDataGridViewTextBoxColumn });
            dataGridView3.DataSource = borrowerBindingSource;
            dataGridView3.Dock = DockStyle.Left;
            dataGridView3.Location = new Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(529, 644);
            dataGridView3.TabIndex = 0;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // borrowerBindingSource
            // 
            borrowerBindingSource.DataSource = typeof(Entities.Borrower);
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(PublisherRemoveBtn);
            tabPage7.Controls.Add(PublisherUpdateBtn);
            tabPage7.Controls.Add(PublisherAddBtn);
            tabPage7.Controls.Add(label17);
            tabPage7.Controls.Add(label13);
            tabPage7.Controls.Add(label12);
            tabPage7.Controls.Add(PublisherAddressTb);
            tabPage7.Controls.Add(PublisherNameTb);
            tabPage7.Controls.Add(PublisherIdTb);
            tabPage7.Controls.Add(dataGridView4);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1154, 650);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Publishers";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // PublisherRemoveBtn
            // 
            PublisherRemoveBtn.Location = new Point(727, 540);
            PublisherRemoveBtn.Name = "PublisherRemoveBtn";
            PublisherRemoveBtn.Size = new Size(251, 46);
            PublisherRemoveBtn.TabIndex = 9;
            PublisherRemoveBtn.Text = "Remove";
            PublisherRemoveBtn.UseVisualStyleBackColor = true;
            PublisherRemoveBtn.Click += PublisherRemoveBtn_Click;
            // 
            // PublisherUpdateBtn
            // 
            PublisherUpdateBtn.Location = new Point(727, 476);
            PublisherUpdateBtn.Name = "PublisherUpdateBtn";
            PublisherUpdateBtn.Size = new Size(251, 46);
            PublisherUpdateBtn.TabIndex = 8;
            PublisherUpdateBtn.Text = "Update";
            PublisherUpdateBtn.UseVisualStyleBackColor = true;
            PublisherUpdateBtn.Click += PublisherUpdateBtn_Click;
            // 
            // PublisherAddBtn
            // 
            PublisherAddBtn.Location = new Point(727, 415);
            PublisherAddBtn.Name = "PublisherAddBtn";
            PublisherAddBtn.Size = new Size(251, 46);
            PublisherAddBtn.TabIndex = 7;
            PublisherAddBtn.Text = "Add";
            PublisherAddBtn.UseVisualStyleBackColor = true;
            PublisherAddBtn.Click += PublisherAddBtn_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(682, 309);
            label17.Name = "label17";
            label17.Size = new Size(124, 20);
            label17.TabIndex = 6;
            label17.Text = "Publisher address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(696, 187);
            label13.Name = "label13";
            label13.Size = new Size(110, 20);
            label13.TabIndex = 5;
            label13.Text = "Publisher name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(739, 71);
            label12.Name = "label12";
            label12.Size = new Size(22, 20);
            label12.TabIndex = 4;
            label12.Text = "Id";
            // 
            // PublisherAddressTb
            // 
            PublisherAddressTb.Location = new Point(812, 306);
            PublisherAddressTb.Name = "PublisherAddressTb";
            PublisherAddressTb.Size = new Size(236, 27);
            PublisherAddressTb.TabIndex = 3;
            // 
            // PublisherNameTb
            // 
            PublisherNameTb.Location = new Point(812, 184);
            PublisherNameTb.Name = "PublisherNameTb";
            PublisherNameTb.Size = new Size(236, 27);
            PublisherNameTb.TabIndex = 2;
            // 
            // PublisherIdTb
            // 
            PublisherIdTb.Location = new Point(812, 68);
            PublisherIdTb.Name = "PublisherIdTb";
            PublisherIdTb.Size = new Size(236, 27);
            PublisherIdTb.TabIndex = 1;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column1, pubNameDataGridViewTextBoxColumn, pubAddressDataGridViewTextBoxColumn });
            dataGridView4.DataSource = publisherBindingSource;
            dataGridView4.Dock = DockStyle.Left;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(559, 650);
            dataGridView4.TabIndex = 0;
            dataGridView4.SelectionChanged += dataGridView4_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PubId";
            Column1.HeaderText = "Publisher Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // pubNameDataGridViewTextBoxColumn
            // 
            pubNameDataGridViewTextBoxColumn.DataPropertyName = "PubName";
            pubNameDataGridViewTextBoxColumn.HeaderText = "PubName";
            pubNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            pubNameDataGridViewTextBoxColumn.Name = "pubNameDataGridViewTextBoxColumn";
            pubNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // pubAddressDataGridViewTextBoxColumn
            // 
            pubAddressDataGridViewTextBoxColumn.DataPropertyName = "PubAddress";
            pubAddressDataGridViewTextBoxColumn.HeaderText = "PubAddress";
            pubAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            pubAddressDataGridViewTextBoxColumn.Name = "pubAddressDataGridViewTextBoxColumn";
            pubAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // publisherBindingSource
            // 
            publisherBindingSource.DataSource = typeof(Entities.Publisher);
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label22);
            tabPage5.Controls.Add(label21);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(BorrowsRemoveBtn);
            tabPage5.Controls.Add(BorrowsUpdateBtn);
            tabPage5.Controls.Add(BorrowsAddBtn);
            tabPage5.Controls.Add(BorrowReturnPicker);
            tabPage5.Controls.Add(BorrowDatePicker);
            tabPage5.Controls.Add(BorrowCopyIdTb);
            tabPage5.Controls.Add(BorrowBorrowerIdTb);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1154, 650);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Borrows";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(756, 336);
            label22.Name = "label22";
            label22.Size = new Size(60, 20);
            label22.TabIndex = 14;
            label22.Text = "Copy Id";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(740, 251);
            label21.Name = "label21";
            label21.Size = new Size(87, 20);
            label21.TabIndex = 13;
            label21.Text = "Borrower Id";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(741, 168);
            label20.Name = "label20";
            label20.Size = new Size(86, 20);
            label20.TabIndex = 12;
            label20.Text = "Return date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(731, 73);
            label19.Name = "label19";
            label19.Size = new Size(112, 20);
            label19.TabIndex = 11;
            label19.Text = "Borrowing date";
            // 
            // BorrowsRemoveBtn
            // 
            BorrowsRemoveBtn.Location = new Point(836, 566);
            BorrowsRemoveBtn.Name = "BorrowsRemoveBtn";
            BorrowsRemoveBtn.Size = new Size(206, 38);
            BorrowsRemoveBtn.TabIndex = 10;
            BorrowsRemoveBtn.Text = "Remove";
            BorrowsRemoveBtn.UseVisualStyleBackColor = true;
            BorrowsRemoveBtn.Click += BorrowsRemoveBtn_Click;
            // 
            // BorrowsUpdateBtn
            // 
            BorrowsUpdateBtn.Location = new Point(836, 509);
            BorrowsUpdateBtn.Name = "BorrowsUpdateBtn";
            BorrowsUpdateBtn.Size = new Size(206, 38);
            BorrowsUpdateBtn.TabIndex = 9;
            BorrowsUpdateBtn.Text = "Update";
            BorrowsUpdateBtn.UseVisualStyleBackColor = true;
            BorrowsUpdateBtn.Click += BorrowsUpdateBtn_Click;
            // 
            // BorrowsAddBtn
            // 
            BorrowsAddBtn.Location = new Point(836, 445);
            BorrowsAddBtn.Name = "BorrowsAddBtn";
            BorrowsAddBtn.Size = new Size(206, 38);
            BorrowsAddBtn.TabIndex = 8;
            BorrowsAddBtn.Text = "Add";
            BorrowsAddBtn.UseVisualStyleBackColor = true;
            BorrowsAddBtn.Click += BorrowsAddBtn_Click;
            // 
            // BorrowReturnPicker
            // 
            BorrowReturnPicker.Format = DateTimePickerFormat.Short;
            BorrowReturnPicker.Location = new Point(891, 163);
            BorrowReturnPicker.Name = "BorrowReturnPicker";
            BorrowReturnPicker.Size = new Size(125, 27);
            BorrowReturnPicker.TabIndex = 6;
            // 
            // BorrowDatePicker
            // 
            BorrowDatePicker.Format = DateTimePickerFormat.Short;
            BorrowDatePicker.Location = new Point(891, 68);
            BorrowDatePicker.Name = "BorrowDatePicker";
            BorrowDatePicker.Size = new Size(125, 27);
            BorrowDatePicker.TabIndex = 5;
            // 
            // BorrowCopyIdTb
            // 
            BorrowCopyIdTb.Location = new Point(849, 333);
            BorrowCopyIdTb.Name = "BorrowCopyIdTb";
            BorrowCopyIdTb.Size = new Size(222, 27);
            BorrowCopyIdTb.TabIndex = 4;
            // 
            // BorrowBorrowerIdTb
            // 
            BorrowBorrowerIdTb.Location = new Point(849, 248);
            BorrowBorrowerIdTb.Name = "BorrowBorrowerIdTb";
            BorrowBorrowerIdTb.Size = new Size(222, 27);
            BorrowBorrowerIdTb.TabIndex = 3;
            // 
            // dataGridView5
            // 
            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, borrowingDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, borrowerIdDataGridViewTextBoxColumn, copyIdDataGridViewTextBoxColumn });
            dataGridView5.DataSource = borrowBindingSource;
            dataGridView5.Dock = DockStyle.Left;
            dataGridView5.Location = new Point(3, 3);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(678, 644);
            dataGridView5.TabIndex = 1;
            dataGridView5.SelectionChanged += dataGridView5_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Borrow_Id";
            dataGridViewTextBoxColumn8.HeaderText = "Borrow_Id";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // borrowingDateDataGridViewTextBoxColumn
            // 
            borrowingDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowingDate";
            borrowingDateDataGridViewTextBoxColumn.HeaderText = "BorrowingDate";
            borrowingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            borrowingDateDataGridViewTextBoxColumn.Name = "borrowingDateDataGridViewTextBoxColumn";
            borrowingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            returnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowerIdDataGridViewTextBoxColumn
            // 
            borrowerIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowerId";
            borrowerIdDataGridViewTextBoxColumn.HeaderText = "BorrowerId";
            borrowerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            borrowerIdDataGridViewTextBoxColumn.Name = "borrowerIdDataGridViewTextBoxColumn";
            borrowerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // copyIdDataGridViewTextBoxColumn
            // 
            copyIdDataGridViewTextBoxColumn.DataPropertyName = "CopyId";
            copyIdDataGridViewTextBoxColumn.HeaderText = "CopyId";
            copyIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            copyIdDataGridViewTextBoxColumn.Name = "copyIdDataGridViewTextBoxColumn";
            copyIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowBindingSource
            // 
            borrowBindingSource.DataSource = typeof(Entities.Borrow);
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label28);
            tabPage6.Controls.Add(label27);
            tabPage6.Controls.Add(label25);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(CopiesRemoveBtn);
            tabPage6.Controls.Add(CopiesUpdateBtn);
            tabPage6.Controls.Add(CopiesAddBtn);
            tabPage6.Controls.Add(CopiesAvailableCheckBox);
            tabPage6.Controls.Add(CopiesIsbnTb);
            tabPage6.Controls.Add(CopiesPeriodTb);
            tabPage6.Controls.Add(CopiesCopyNumberTb);
            tabPage6.Controls.Add(CopiesCopyIdTb);
            tabPage6.Controls.Add(DataGridCopies);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1154, 650);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Copies";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(770, 368);
            label28.Name = "label28";
            label28.Size = new Size(36, 20);
            label28.TabIndex = 13;
            label28.Text = "Isbn";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(723, 286);
            label27.Name = "label27";
            label27.Size = new Size(126, 20);
            label27.TabIndex = 12;
            label27.Text = "Borrowing period";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(751, 136);
            label25.Name = "label25";
            label25.Size = new Size(98, 20);
            label25.TabIndex = 10;
            label25.Text = "Copy number";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(770, 60);
            label18.Name = "label18";
            label18.Size = new Size(60, 20);
            label18.TabIndex = 9;
            label18.Text = "Copy Id";
            // 
            // CopiesRemoveBtn
            // 
            CopiesRemoveBtn.Location = new Point(794, 580);
            CopiesRemoveBtn.Name = "CopiesRemoveBtn";
            CopiesRemoveBtn.Size = new Size(248, 39);
            CopiesRemoveBtn.TabIndex = 8;
            CopiesRemoveBtn.Text = "Remove";
            CopiesRemoveBtn.UseVisualStyleBackColor = true;
            CopiesRemoveBtn.Click += CopiesRemoveBtn_Click;
            // 
            // CopiesUpdateBtn
            // 
            CopiesUpdateBtn.Location = new Point(794, 514);
            CopiesUpdateBtn.Name = "CopiesUpdateBtn";
            CopiesUpdateBtn.Size = new Size(248, 39);
            CopiesUpdateBtn.TabIndex = 7;
            CopiesUpdateBtn.Text = "Update";
            CopiesUpdateBtn.UseVisualStyleBackColor = true;
            CopiesUpdateBtn.Click += CopiesUpdateBtn_Click;
            // 
            // CopiesAddBtn
            // 
            CopiesAddBtn.Location = new Point(794, 441);
            CopiesAddBtn.Name = "CopiesAddBtn";
            CopiesAddBtn.Size = new Size(248, 39);
            CopiesAddBtn.TabIndex = 6;
            CopiesAddBtn.Text = "Add";
            CopiesAddBtn.UseVisualStyleBackColor = true;
            CopiesAddBtn.Click += CopiesAddBtn_Click;
            // 
            // CopiesAvailableCheckBox
            // 
            CopiesAvailableCheckBox.AutoSize = true;
            CopiesAvailableCheckBox.Location = new Point(870, 212);
            CopiesAvailableCheckBox.Name = "CopiesAvailableCheckBox";
            CopiesAvailableCheckBox.Size = new Size(93, 24);
            CopiesAvailableCheckBox.TabIndex = 5;
            CopiesAvailableCheckBox.Text = "Available";
            CopiesAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopiesIsbnTb
            // 
            CopiesIsbnTb.Location = new Point(870, 365);
            CopiesIsbnTb.Name = "CopiesIsbnTb";
            CopiesIsbnTb.Size = new Size(215, 27);
            CopiesIsbnTb.TabIndex = 4;
            // 
            // CopiesPeriodTb
            // 
            CopiesPeriodTb.Location = new Point(870, 283);
            CopiesPeriodTb.Name = "CopiesPeriodTb";
            CopiesPeriodTb.Size = new Size(215, 27);
            CopiesPeriodTb.TabIndex = 3;
            // 
            // CopiesCopyNumberTb
            // 
            CopiesCopyNumberTb.Location = new Point(870, 133);
            CopiesCopyNumberTb.Name = "CopiesCopyNumberTb";
            CopiesCopyNumberTb.Size = new Size(215, 27);
            CopiesCopyNumberTb.TabIndex = 2;
            // 
            // CopiesCopyIdTb
            // 
            CopiesCopyIdTb.Location = new Point(870, 57);
            CopiesCopyIdTb.Name = "CopiesCopyIdTb";
            CopiesCopyIdTb.Size = new Size(215, 27);
            CopiesCopyIdTb.TabIndex = 1;
            // 
            // DataGridCopies
            // 
            DataGridCopies.AutoGenerateColumns = false;
            DataGridCopies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCopies.Columns.AddRange(new DataGridViewColumn[] { copyIdDataGridViewTextBoxColumn1, copyNumberDataGridViewTextBoxColumn, availableDataGridViewTextBoxColumn, borrowingPeriodDataGridViewTextBoxColumn, isbnDataGridViewTextBoxColumn1 });
            DataGridCopies.DataSource = copyBindingSource;
            DataGridCopies.Dock = DockStyle.Left;
            DataGridCopies.Location = new Point(3, 3);
            DataGridCopies.Name = "DataGridCopies";
            DataGridCopies.RowHeadersWidth = 51;
            DataGridCopies.Size = new Size(678, 644);
            DataGridCopies.TabIndex = 0;
            DataGridCopies.SelectionChanged += DataGridCopies_SelectionChanged;
            // 
            // copyIdDataGridViewTextBoxColumn1
            // 
            copyIdDataGridViewTextBoxColumn1.DataPropertyName = "CopyId";
            copyIdDataGridViewTextBoxColumn1.HeaderText = "CopyId";
            copyIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            copyIdDataGridViewTextBoxColumn1.Name = "copyIdDataGridViewTextBoxColumn1";
            copyIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // copyNumberDataGridViewTextBoxColumn
            // 
            copyNumberDataGridViewTextBoxColumn.DataPropertyName = "CopyNumber";
            copyNumberDataGridViewTextBoxColumn.HeaderText = "CopyNumber";
            copyNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            copyNumberDataGridViewTextBoxColumn.Name = "copyNumberDataGridViewTextBoxColumn";
            copyNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableDataGridViewTextBoxColumn
            // 
            availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            availableDataGridViewTextBoxColumn.HeaderText = "Available";
            availableDataGridViewTextBoxColumn.MinimumWidth = 6;
            availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            availableDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingPeriodDataGridViewTextBoxColumn
            // 
            borrowingPeriodDataGridViewTextBoxColumn.DataPropertyName = "BorrowingPeriod";
            borrowingPeriodDataGridViewTextBoxColumn.HeaderText = "BorrowingPeriod";
            borrowingPeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            borrowingPeriodDataGridViewTextBoxColumn.Name = "borrowingPeriodDataGridViewTextBoxColumn";
            borrowingPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn1
            // 
            isbnDataGridViewTextBoxColumn1.DataPropertyName = "Isbn";
            isbnDataGridViewTextBoxColumn1.HeaderText = "Isbn";
            isbnDataGridViewTextBoxColumn1.MinimumWidth = 6;
            isbnDataGridViewTextBoxColumn1.Name = "isbnDataGridViewTextBoxColumn1";
            isbnDataGridViewTextBoxColumn1.Width = 125;
            // 
            // copyBindingSource
            // 
            copyBindingSource.DataSource = typeof(Entities.Copy);
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(CategoryRemoveBtn);
            tabPage8.Controls.Add(CategoryUpdateBtn);
            tabPage8.Controls.Add(label29);
            tabPage8.Controls.Add(CategoryNameTb);
            tabPage8.Controls.Add(CategoryIdTb);
            tabPage8.Controls.Add(CategoryAddBtn);
            tabPage8.Controls.Add(label26);
            tabPage8.Controls.Add(DataGridCategory);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1154, 650);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Categories";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // CategoryRemoveBtn
            // 
            CategoryRemoveBtn.Location = new Point(578, 507);
            CategoryRemoveBtn.Name = "CategoryRemoveBtn";
            CategoryRemoveBtn.Size = new Size(255, 48);
            CategoryRemoveBtn.TabIndex = 7;
            CategoryRemoveBtn.Text = "Remove";
            CategoryRemoveBtn.UseVisualStyleBackColor = true;
            CategoryRemoveBtn.Click += CategoryRemoveBtn_Click;
            // 
            // CategoryUpdateBtn
            // 
            CategoryUpdateBtn.Location = new Point(578, 438);
            CategoryUpdateBtn.Name = "CategoryUpdateBtn";
            CategoryUpdateBtn.Size = new Size(255, 48);
            CategoryUpdateBtn.TabIndex = 6;
            CategoryUpdateBtn.Text = "Update";
            CategoryUpdateBtn.UseVisualStyleBackColor = true;
            CategoryUpdateBtn.Click += CategoryUpdateBtn_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(526, 171);
            label29.Name = "label29";
            label29.Size = new Size(69, 20);
            label29.TabIndex = 5;
            label29.Text = "Category";
            // 
            // CategoryNameTb
            // 
            CategoryNameTb.Location = new Point(639, 168);
            CategoryNameTb.Name = "CategoryNameTb";
            CategoryNameTb.Size = new Size(228, 27);
            CategoryNameTb.TabIndex = 4;
            // 
            // CategoryIdTb
            // 
            CategoryIdTb.Location = new Point(639, 80);
            CategoryIdTb.Name = "CategoryIdTb";
            CategoryIdTb.Size = new Size(228, 27);
            CategoryIdTb.TabIndex = 3;
            // 
            // CategoryAddBtn
            // 
            CategoryAddBtn.Location = new Point(578, 369);
            CategoryAddBtn.Name = "CategoryAddBtn";
            CategoryAddBtn.Size = new Size(255, 48);
            CategoryAddBtn.TabIndex = 2;
            CategoryAddBtn.Text = "Add";
            CategoryAddBtn.UseVisualStyleBackColor = true;
            CategoryAddBtn.Click += CategoryAddBtn_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(526, 83);
            label26.Name = "label26";
            label26.Size = new Size(22, 20);
            label26.TabIndex = 1;
            label26.Text = "Id";
            // 
            // DataGridCategory
            // 
            DataGridCategory.AutoGenerateColumns = false;
            DataGridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCategory.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, catNameDataGridViewTextBoxColumn });
            DataGridCategory.DataSource = categoryBindingSource;
            DataGridCategory.Location = new Point(1, 2);
            DataGridCategory.Name = "DataGridCategory";
            DataGridCategory.RowHeadersWidth = 51;
            DataGridCategory.Size = new Size(304, 644);
            DataGridCategory.TabIndex = 0;
            DataGridCategory.SelectionChanged += DataGridCategory_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "CatId";
            dataGridViewTextBoxColumn10.HeaderText = "Category Id";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            catNameDataGridViewTextBoxColumn.DataPropertyName = "CatName";
            catNameDataGridViewTextBoxColumn.HeaderText = "Category";
            catNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            catNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Entities.Category);
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(label31);
            tabPage9.Controls.Add(label30);
            tabPage9.Controls.Add(BorrowerPhoneRemoveBtn);
            tabPage9.Controls.Add(BorrowerPhoneUpdateBtn);
            tabPage9.Controls.Add(BorrowerPhoneAddBtn);
            tabPage9.Controls.Add(BorrowerPhoneTb);
            tabPage9.Controls.Add(BorrowerPhoneIdTb);
            tabPage9.Controls.Add(DataGridBorrowersPhone);
            tabPage9.Location = new Point(4, 29);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(1154, 650);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "Borrowers Phones";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(622, 203);
            label31.Name = "label31";
            label31.Size = new Size(50, 20);
            label31.TabIndex = 7;
            label31.Text = "Phone";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(622, 119);
            label30.Name = "label30";
            label30.Size = new Size(22, 20);
            label30.TabIndex = 6;
            label30.Text = "Id";
            // 
            // BorrowerPhoneRemoveBtn
            // 
            BorrowerPhoneRemoveBtn.Location = new Point(603, 515);
            BorrowerPhoneRemoveBtn.Name = "BorrowerPhoneRemoveBtn";
            BorrowerPhoneRemoveBtn.Size = new Size(253, 50);
            BorrowerPhoneRemoveBtn.TabIndex = 5;
            BorrowerPhoneRemoveBtn.Text = "Remove";
            BorrowerPhoneRemoveBtn.UseVisualStyleBackColor = true;
            BorrowerPhoneRemoveBtn.Click += BorrowerPhoneRemoveBtn_Click;
            // 
            // BorrowerPhoneUpdateBtn
            // 
            BorrowerPhoneUpdateBtn.Location = new Point(603, 433);
            BorrowerPhoneUpdateBtn.Name = "BorrowerPhoneUpdateBtn";
            BorrowerPhoneUpdateBtn.Size = new Size(253, 50);
            BorrowerPhoneUpdateBtn.TabIndex = 4;
            BorrowerPhoneUpdateBtn.Text = "Update";
            BorrowerPhoneUpdateBtn.UseVisualStyleBackColor = true;
            BorrowerPhoneUpdateBtn.Click += BorrowerPhoneUpdateBtn_Click;
            // 
            // BorrowerPhoneAddBtn
            // 
            BorrowerPhoneAddBtn.Location = new Point(603, 360);
            BorrowerPhoneAddBtn.Name = "BorrowerPhoneAddBtn";
            BorrowerPhoneAddBtn.Size = new Size(253, 50);
            BorrowerPhoneAddBtn.TabIndex = 3;
            BorrowerPhoneAddBtn.Text = "Add";
            BorrowerPhoneAddBtn.UseVisualStyleBackColor = true;
            BorrowerPhoneAddBtn.Click += BorrowerPhoneAddBtn_Click;
            // 
            // BorrowerPhoneTb
            // 
            BorrowerPhoneTb.Location = new Point(718, 200);
            BorrowerPhoneTb.Name = "BorrowerPhoneTb";
            BorrowerPhoneTb.Size = new Size(225, 27);
            BorrowerPhoneTb.TabIndex = 2;
            // 
            // BorrowerPhoneIdTb
            // 
            BorrowerPhoneIdTb.Location = new Point(718, 116);
            BorrowerPhoneIdTb.Name = "BorrowerPhoneIdTb";
            BorrowerPhoneIdTb.Size = new Size(225, 27);
            BorrowerPhoneIdTb.TabIndex = 1;
            // 
            // DataGridBorrowersPhone
            // 
            DataGridBorrowersPhone.AutoGenerateColumns = false;
            DataGridBorrowersPhone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBorrowersPhone.Columns.AddRange(new DataGridViewColumn[] { brrIdDataGridViewTextBoxColumn1, brrPhoneDataGridViewTextBoxColumn });
            DataGridBorrowersPhone.DataSource = phoneBorrowerBindingSource;
            DataGridBorrowersPhone.Dock = DockStyle.Left;
            DataGridBorrowersPhone.Location = new Point(0, 0);
            DataGridBorrowersPhone.Name = "DataGridBorrowersPhone";
            DataGridBorrowersPhone.RowHeadersWidth = 51;
            DataGridBorrowersPhone.Size = new Size(358, 650);
            DataGridBorrowersPhone.TabIndex = 0;
            DataGridBorrowersPhone.SelectionChanged += DataGridBorrowersPhone_SelectionChanged;
            // 
            // phoneBorrowerBindingSource
            // 
            phoneBorrowerBindingSource.DataSource = typeof(Entities.PhoneBorrower);
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(PublisherPhoneRemoveBtn);
            tabPage10.Controls.Add(PublisherPhoneUpdateBtn);
            tabPage10.Controls.Add(PublisherPhoneAddBtn);
            tabPage10.Controls.Add(label33);
            tabPage10.Controls.Add(label32);
            tabPage10.Controls.Add(PublisherPhoneTb);
            tabPage10.Controls.Add(PublisherPhoneIdTb);
            tabPage10.Controls.Add(DataGridPublisherPhone);
            tabPage10.Location = new Point(4, 29);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(1154, 650);
            tabPage10.TabIndex = 9;
            tabPage10.Text = "Publishers Phones";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // PublisherPhoneRemoveBtn
            // 
            PublisherPhoneRemoveBtn.Location = new Point(610, 515);
            PublisherPhoneRemoveBtn.Name = "PublisherPhoneRemoveBtn";
            PublisherPhoneRemoveBtn.Size = new Size(281, 52);
            PublisherPhoneRemoveBtn.TabIndex = 7;
            PublisherPhoneRemoveBtn.Text = "Remove";
            PublisherPhoneRemoveBtn.UseVisualStyleBackColor = true;
            PublisherPhoneRemoveBtn.Click += PublisherPhoneRemoveBtn_Click;
            // 
            // PublisherPhoneUpdateBtn
            // 
            PublisherPhoneUpdateBtn.Location = new Point(610, 443);
            PublisherPhoneUpdateBtn.Name = "PublisherPhoneUpdateBtn";
            PublisherPhoneUpdateBtn.Size = new Size(281, 52);
            PublisherPhoneUpdateBtn.TabIndex = 6;
            PublisherPhoneUpdateBtn.Text = "Update";
            PublisherPhoneUpdateBtn.UseVisualStyleBackColor = true;
            PublisherPhoneUpdateBtn.Click += PublisherPhoneUpdateBtn_Click;
            // 
            // PublisherPhoneAddBtn
            // 
            PublisherPhoneAddBtn.Location = new Point(610, 378);
            PublisherPhoneAddBtn.Name = "PublisherPhoneAddBtn";
            PublisherPhoneAddBtn.Size = new Size(281, 52);
            PublisherPhoneAddBtn.TabIndex = 5;
            PublisherPhoneAddBtn.Text = "Add";
            PublisherPhoneAddBtn.UseVisualStyleBackColor = true;
            PublisherPhoneAddBtn.Click += PublisherPhoneAddBtn_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(582, 218);
            label33.Name = "label33";
            label33.Size = new Size(50, 20);
            label33.TabIndex = 4;
            label33.Text = "Phone";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(582, 96);
            label32.Name = "label32";
            label32.Size = new Size(22, 20);
            label32.TabIndex = 3;
            label32.Text = "Id";
            // 
            // PublisherPhoneTb
            // 
            PublisherPhoneTb.Location = new Point(676, 215);
            PublisherPhoneTb.Name = "PublisherPhoneTb";
            PublisherPhoneTb.Size = new Size(256, 27);
            PublisherPhoneTb.TabIndex = 2;
            // 
            // PublisherPhoneIdTb
            // 
            PublisherPhoneIdTb.Location = new Point(676, 93);
            PublisherPhoneIdTb.Name = "PublisherPhoneIdTb";
            PublisherPhoneIdTb.Size = new Size(256, 27);
            PublisherPhoneIdTb.TabIndex = 1;
            // 
            // DataGridPublisherPhone
            // 
            DataGridPublisherPhone.AutoGenerateColumns = false;
            DataGridPublisherPhone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPublisherPhone.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            DataGridPublisherPhone.DataSource = phonePublisherBindingSource;
            DataGridPublisherPhone.Dock = DockStyle.Left;
            DataGridPublisherPhone.Location = new Point(0, 0);
            DataGridPublisherPhone.Name = "DataGridPublisherPhone";
            DataGridPublisherPhone.RowHeadersWidth = 51;
            DataGridPublisherPhone.Size = new Size(359, 650);
            DataGridPublisherPhone.TabIndex = 0;
            DataGridPublisherPhone.SelectionChanged += DataGridPublisherPhone_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "PubId";
            dataGridViewTextBoxColumn11.HeaderText = "Publisher Id";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn12.HeaderText = "Phone";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 180;
            // 
            // phonePublisherBindingSource
            // 
            phonePublisherBindingSource.DataSource = typeof(Entities.PhonePublisher);
            // 
            // brrIdDataGridViewTextBoxColumn1
            // 
            brrIdDataGridViewTextBoxColumn1.DataPropertyName = "BrrId";
            brrIdDataGridViewTextBoxColumn1.HeaderText = "Borrower Id";
            brrIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            brrIdDataGridViewTextBoxColumn1.Name = "brrIdDataGridViewTextBoxColumn1";
            brrIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // brrPhoneDataGridViewTextBoxColumn
            // 
            brrPhoneDataGridViewTextBoxColumn.DataPropertyName = "BrrPhone";
            brrPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            brrPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            brrPhoneDataGridViewTextBoxColumn.Name = "brrPhoneDataGridViewTextBoxColumn";
            brrPhoneDataGridViewTextBoxColumn.Width = 180;
            // 
            // brrIdDataGridViewTextBoxColumn
            // 
            brrIdDataGridViewTextBoxColumn.DataPropertyName = "BrrId";
            brrIdDataGridViewTextBoxColumn.HeaderText = "BrrId";
            brrIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            brrIdDataGridViewTextBoxColumn.Name = "brrIdDataGridViewTextBoxColumn";
            brrIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // brrNameDataGridViewTextBoxColumn
            // 
            brrNameDataGridViewTextBoxColumn.DataPropertyName = "BrrName";
            brrNameDataGridViewTextBoxColumn.HeaderText = "BrrName";
            brrNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            brrNameDataGridViewTextBoxColumn.Name = "brrNameDataGridViewTextBoxColumn";
            brrNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // brrAddressDataGridViewTextBoxColumn
            // 
            brrAddressDataGridViewTextBoxColumn.DataPropertyName = "BrrAddress";
            brrAddressDataGridViewTextBoxColumn.HeaderText = "BrrAddress";
            brrAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            brrAddressDataGridViewTextBoxColumn.Name = "brrAddressDataGridViewTextBoxColumn";
            brrAddressDataGridViewTextBoxColumn.Width = 180;
            // 
            // auIdDataGridViewTextBoxColumn
            // 
            auIdDataGridViewTextBoxColumn.DataPropertyName = "AuId";
            auIdDataGridViewTextBoxColumn.HeaderText = "AuId";
            auIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            auIdDataGridViewTextBoxColumn.Name = "auIdDataGridViewTextBoxColumn";
            auIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // midNameDataGridViewTextBoxColumn
            // 
            midNameDataGridViewTextBoxColumn.DataPropertyName = "MidName";
            midNameDataGridViewTextBoxColumn.HeaderText = "MidName";
            midNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            midNameDataGridViewTextBoxColumn.Name = "midNameDataGridViewTextBoxColumn";
            midNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Isbn";
            dataGridViewTextBoxColumn1.HeaderText = "Isbn";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            dataGridViewTextBoxColumn2.HeaderText = "Title";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Edition";
            dataGridViewTextBoxColumn3.HeaderText = "Edition";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "YearOfPublication";
            dataGridViewTextBoxColumn4.HeaderText = "YearOfPublication";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            dataGridViewTextBoxColumn5.HeaderText = "Price";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "CatId";
            dataGridViewTextBoxColumn6.HeaderText = "CatId";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "PubId";
            dataGridViewTextBoxColumn7.HeaderText = "PubId";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 683);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "انا الداتابيز";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridAuthorities).EndInit();
            ((System.ComponentModel.ISupportInitialize)authoritiesBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowerBindingSource).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)publisherBindingSource).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowBindingSource).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridCopies).EndInit();
            ((System.ComponentModel.ISupportInitialize)copyBindingSource).EndInit();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridBorrowersPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneBorrowerBindingSource).EndInit();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridPublisherPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)phonePublisherBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView DataGridBooks;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DateTimePicker BookYearTb;
        private TextBox BookPublisherIdTb;
        private TextBox BookCategoryIdTb;
        private TextBox BookPriceTb;
        private TextBox BookEditionTb;
        private TextBox BookTitleTb;
        private TextBox BookISBNTb;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BookAddBtn;
        private Button BookUpdateBtn;
        private Button BookRemoveBtn;
        private DataGridView dataGridView2;
        private Label label9;
        private Label label8;
        private TextBox AuthorMidTb;
        private TextBox AuthorLastTb;
        private TextBox AuthorFirstTb;
        private TextBox AuthorIdTb;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Label label11;
        private Label label10;
        private Button AuthorRemoveBtn;
        private Button AuthorUpdateBtn;
        private Button AuthorAddBtn;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox BorrowereAddressTb;
        private TextBox BorrowerNameTb;
        private TextBox BorrowerIdTb;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private Button BorrowereRemoveBtn;
        private Button BorrowereUpdateBtn;
        private Button BorrowereAddBtn;
        private DataGridViewTextBoxColumn yearofpublicationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private TabPage tabPage10;
        private DataGridView dataGridView4;
        private TextBox PublisherAddressTb;
        private TextBox PublisherNameTb;
        private TextBox PublisherIdTb;
        private Button PublisherRemoveBtn;
        private Button PublisherUpdateBtn;
        private Button PublisherAddBtn;
        private Label label17;
        private Label label13;
        private Label label12;
        private DataGridView dataGridView5;
        private Button BorrowsRemoveBtn;
        private Button BorrowsUpdateBtn;
        private Button BorrowsAddBtn;
        private DateTimePicker BorrowReturnPicker;
        private DateTimePicker BorrowDatePicker;
        private TextBox BorrowCopyIdTb;
        private TextBox BorrowBorrowerIdTb;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private BindingSource bookBindingSource;
        private TabPage tabPage4;
        private DataGridView DataGridAuthorities;
        private BindingSource authorBindingSource;
        private BindingSource borrowerBindingSource;
        private BindingSource publisherBindingSource;
        private DataGridViewTextBoxColumn borrowIdDataGridViewTextBoxColumn;
        private Label label23;
        private Button AuthoritiesAddBtn;
        private TextBox AuthoritiesIsbnTb;
        private TextBox AuthoritiesAuthorIdTb;
        private Button AuthoritiesRemoveBtn;
        private Button AuthoritiesUpdateBtn;
        private Label label24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn borrowingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copyIdDataGridViewTextBoxColumn;
        private BindingSource borrowBindingSource;
        private Button CopiesRemoveBtn;
        private Button CopiesUpdateBtn;
        private Button CopiesAddBtn;
        private CheckBox CopiesAvailableCheckBox;
        private TextBox CopiesIsbnTb;
        private TextBox CopiesPeriodTb;
        private TextBox CopiesCopyNumberTb;
        private TextBox CopiesCopyIdTb;
        private DataGridView DataGridCopies;
        private DataGridViewTextBoxColumn copyIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn copyNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingPeriodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn1;
        private BindingSource copyBindingSource;
        private Label label28;
        private Label label27;
        private Label label25;
        private Label label18;
        private DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private BindingSource authoritiesBindingSource;
        private DataGridView DataGridCategory;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn pubNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubAddressDataGridViewTextBoxColumn;
        private Button CategoryAddBtn;
        private Label label26;
        private Button CategoryRemoveBtn;
        private Button CategoryUpdateBtn;
        private Label label29;
        private TextBox CategoryNameTb;
        private TextBox CategoryIdTb;
        private DataGridView DataGridBorrowersPhone;
        private BindingSource phoneBorrowerBindingSource;
        private Button BorrowerPhoneAddBtn;
        private TextBox BorrowerPhoneTb;
        private TextBox BorrowerPhoneIdTb;
        private Button BorrowerPhoneRemoveBtn;
        private Button BorrowerPhoneUpdateBtn;
        private Label label31;
        private Label label30;
        private TextBox PublisherPhoneTb;
        private TextBox PublisherPhoneIdTb;
        private DataGridView DataGridPublisherPhone;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private BindingSource phonePublisherBindingSource;
        private Button PublisherPhoneRemoveBtn;
        private Button PublisherPhoneUpdateBtn;
        private Button PublisherPhoneAddBtn;
        private Label label33;
        private Label label32;
        private DataGridViewTextBoxColumn brrIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn brrPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn auIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn midNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brrIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brrNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brrAddressDataGridViewTextBoxColumn;
    }
}
