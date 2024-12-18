﻿namespace LibraryProject
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
            dataGridView1 = new DataGridView();
            isbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearofpublicationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            AuthorRemoveBtn = new Button();
            AuthorUpdateBtn = new Button();
            AuthorAddBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            AuthorEmailTb = new TextBox();
            AuthorLastTb = new TextBox();
            AuthorFirstTb = new TextBox();
            AuthorIdTb = new TextBox();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            AuthorNameColumn = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
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
            tabPage1.Controls.Add(dataGridView1);
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
            BookAddBtn.Location = new Point(925, 595);
            BookAddBtn.Name = "BookAddBtn";
            BookAddBtn.Size = new Size(173, 33);
            BookAddBtn.TabIndex = 20;
            BookAddBtn.Text = "Add";
            BookAddBtn.UseVisualStyleBackColor = true;
            BookAddBtn.Click += BookAddBtn_Click;
            // 
            // BookUpdateBtn
            // 
            BookUpdateBtn.Location = new Point(925, 556);
            BookUpdateBtn.Name = "BookUpdateBtn";
            BookUpdateBtn.Size = new Size(173, 33);
            BookUpdateBtn.TabIndex = 19;
            BookUpdateBtn.Text = "Update";
            BookUpdateBtn.UseVisualStyleBackColor = true;
            BookUpdateBtn.Click += BookUpdateBtn_Click;
            // 
            // BookRemoveBtn
            // 
            BookRemoveBtn.Location = new Point(925, 517);
            BookRemoveBtn.Name = "BookRemoveBtn";
            BookRemoveBtn.Size = new Size(173, 33);
            BookRemoveBtn.TabIndex = 18;
            BookRemoveBtn.Text = "Remove";
            BookRemoveBtn.UseVisualStyleBackColor = true;
            BookRemoveBtn.Click += BookRemoveBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(865, 465);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 17;
            label7.Text = "Publisher Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(865, 401);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 16;
            label6.Text = "Category Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(877, 327);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 15;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(865, 278);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 14;
            label4.Text = "Publication year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(877, 226);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 13;
            label3.Text = "Edition";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(889, 146);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 12;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(877, 67);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 11;
            label1.Text = "ISBN";
            // 
            // BookYearTb
            // 
            BookYearTb.Format = DateTimePickerFormat.Short;
            BookYearTb.Location = new Point(998, 273);
            BookYearTb.Name = "BookYearTb";
            BookYearTb.Size = new Size(123, 27);
            BookYearTb.TabIndex = 10;
            // 
            // BookPublisherIdTb
            // 
            BookPublisherIdTb.Location = new Point(950, 462);
            BookPublisherIdTb.Name = "BookPublisherIdTb";
            BookPublisherIdTb.Size = new Size(183, 27);
            BookPublisherIdTb.TabIndex = 9;
            // 
            // BookCategoryIdTb
            // 
            BookCategoryIdTb.Location = new Point(950, 398);
            BookCategoryIdTb.Name = "BookCategoryIdTb";
            BookCategoryIdTb.Size = new Size(183, 27);
            BookCategoryIdTb.TabIndex = 8;
            // 
            // BookPriceTb
            // 
            BookPriceTb.Location = new Point(950, 320);
            BookPriceTb.Name = "BookPriceTb";
            BookPriceTb.Size = new Size(183, 27);
            BookPriceTb.TabIndex = 7;
            // 
            // BookEditionTb
            // 
            BookEditionTb.Location = new Point(950, 219);
            BookEditionTb.Name = "BookEditionTb";
            BookEditionTb.Size = new Size(183, 27);
            BookEditionTb.TabIndex = 6;
            // 
            // BookTitleTb
            // 
            BookTitleTb.Location = new Point(950, 139);
            BookTitleTb.Name = "BookTitleTb";
            BookTitleTb.Size = new Size(183, 27);
            BookTitleTb.TabIndex = 5;
            // 
            // BookISBNTb
            // 
            BookISBNTb.Location = new Point(950, 64);
            BookISBNTb.Name = "BookISBNTb";
            BookISBNTb.Size = new Size(183, 27);
            BookISBNTb.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { isbnDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, editionDataGridViewTextBoxColumn, yearofpublicationDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, catIdDataGridViewTextBoxColumn, pubidDataGridViewTextBoxColumn, AuthorNameColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(848, 644);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            editionDataGridViewTextBoxColumn.DataPropertyName = "Edition";
            editionDataGridViewTextBoxColumn.HeaderText = "Edition";
            editionDataGridViewTextBoxColumn.MinimumWidth = 6;
            editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            editionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearofpublicationDataGridViewTextBoxColumn
            // 
            yearofpublicationDataGridViewTextBoxColumn.DataPropertyName = "Yearofpublication";
            yearofpublicationDataGridViewTextBoxColumn.HeaderText = "Yearofpublication";
            yearofpublicationDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearofpublicationDataGridViewTextBoxColumn.Name = "yearofpublicationDataGridViewTextBoxColumn";
            yearofpublicationDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            catIdDataGridViewTextBoxColumn.DataPropertyName = "CatId";
            catIdDataGridViewTextBoxColumn.HeaderText = "CatId";
            catIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            catIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pubidDataGridViewTextBoxColumn
            // 
            pubidDataGridViewTextBoxColumn.DataPropertyName = "Pubid";
            pubidDataGridViewTextBoxColumn.HeaderText = "Pubid";
            pubidDataGridViewTextBoxColumn.MinimumWidth = 6;
            pubidDataGridViewTextBoxColumn.Name = "pubidDataGridViewTextBoxColumn";
            pubidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Entities.Book);
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
            tabPage2.Controls.Add(AuthorEmailTb);
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
            AuthorRemoveBtn.Location = new Point(857, 577);
            AuthorRemoveBtn.Name = "AuthorRemoveBtn";
            AuthorRemoveBtn.Size = new Size(198, 37);
            AuthorRemoveBtn.TabIndex = 11;
            AuthorRemoveBtn.Text = "Remove";
            AuthorRemoveBtn.UseVisualStyleBackColor = true;
            AuthorRemoveBtn.Click += AuthorRemoveBtn_Click;
            // 
            // AuthorUpdateBtn
            // 
            AuthorUpdateBtn.Location = new Point(857, 510);
            AuthorUpdateBtn.Name = "AuthorUpdateBtn";
            AuthorUpdateBtn.Size = new Size(198, 37);
            AuthorUpdateBtn.TabIndex = 10;
            AuthorUpdateBtn.Text = "Update";
            AuthorUpdateBtn.UseVisualStyleBackColor = true;
            AuthorUpdateBtn.Click += AuthorUpdateBtn_Click;
            // 
            // AuthorAddBtn
            // 
            AuthorAddBtn.Location = new Point(857, 446);
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
            label11.Location = new Point(782, 304);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 8;
            label11.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(766, 228);
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
            // AuthorEmailTb
            // 
            AuthorEmailTb.Location = new Point(873, 301);
            AuthorEmailTb.Name = "AuthorEmailTb";
            AuthorEmailTb.Size = new Size(218, 27);
            AuthorEmailTb.TabIndex = 4;
            // 
            // AuthorLastTb
            // 
            AuthorLastTb.Location = new Point(873, 221);
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
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstnameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dataGridView2.DataSource = authorBindingSource;
            dataGridView2.Dock = DockStyle.Left;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(669, 644);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 240;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Entities.Author);
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1154, 650);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Customers";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1154, 650);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1154, 650);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1154, 650);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // AuthorNameColumn
            // 
            AuthorNameColumn.HeaderText = "Author";
            AuthorNameColumn.MinimumWidth = 6;
            AuthorNameColumn.Name = "AuthorNameColumn";
            AuthorNameColumn.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private TabPage tabPage3;
        private TabPage tabPage4;
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
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearofpublicationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pubidDataGridViewTextBoxColumn;
        private DataGridView dataGridView2;
        private Label label9;
        private Label label8;
        private TextBox AuthorEmailTb;
        private TextBox AuthorLastTb;
        private TextBox AuthorFirstTb;
        private TextBox AuthorIdTb;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource authorBindingSource;
        private Label label11;
        private Label label10;
        private Button AuthorRemoveBtn;
        private Button AuthorUpdateBtn;
        private Button AuthorAddBtn;
        private DataGridViewTextBoxColumn AuthorNameColumn;
    }
}
