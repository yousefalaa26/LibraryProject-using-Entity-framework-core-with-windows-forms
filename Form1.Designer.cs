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
            dataGridView1 = new DataGridView();
            bookBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            isbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearofpublicationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pubidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
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
            BookAddBtn.Location = new Point(550, 590);
            BookAddBtn.Name = "BookAddBtn";
            BookAddBtn.Size = new Size(173, 33);
            BookAddBtn.TabIndex = 20;
            BookAddBtn.Text = "Add";
            BookAddBtn.UseVisualStyleBackColor = true;
            BookAddBtn.Click += BookAddBtn_Click;
            // 
            // BookUpdateBtn
            // 
            BookUpdateBtn.Location = new Point(760, 590);
            BookUpdateBtn.Name = "BookUpdateBtn";
            BookUpdateBtn.Size = new Size(173, 33);
            BookUpdateBtn.TabIndex = 19;
            BookUpdateBtn.Text = "Update";
            BookUpdateBtn.UseVisualStyleBackColor = true;
            BookUpdateBtn.Click += BookUpdateBtn_Click;
            // 
            // BookRemoveBtn
            // 
            BookRemoveBtn.Location = new Point(960, 590);
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
            label7.Location = new Point(865, 487);
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
            BookPublisherIdTb.Location = new Point(950, 484);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { isbnDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, editionDataGridViewTextBoxColumn, yearofpublicationDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, catIdDataGridViewTextBoxColumn, pubidDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(11, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(848, 566);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Entities.Book);
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1154, 650);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Authors";
            tabPage2.UseVisualStyleBackColor = true;
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
    }
}
