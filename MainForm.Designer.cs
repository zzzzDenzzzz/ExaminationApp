namespace ExaminationApp
{
    partial class MainForm
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
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblTitleFilter = new System.Windows.Forms.Label();
            this.txtTitleFilter = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthorFilter = new System.Windows.Forms.TextBox();
            this.lblGenreFilter = new System.Windows.Forms.Label();
            this.cmbGenreFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnNewBooksList = new System.Windows.Forms.Button();
            this.btnTopSales = new System.Windows.Forms.Button();
            this.btnTopAuthors = new System.Windows.Forms.Button();
            this.BtnTopGenresWeek = new System.Windows.Forms.Button();
            this.btnTopGenresMonth = new System.Windows.Forms.Button();
            this.btnTopGenresYear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBooks
            // 
            this.gridBooks.AllowUserToAddRows = false;
            this.gridBooks.AllowUserToDeleteRows = false;
            this.gridBooks.AllowUserToResizeColumns = false;
            this.gridBooks.AllowUserToResizeRows = false;
            this.gridBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridBooks.Location = new System.Drawing.Point(12, 104);
            this.gridBooks.MultiSelect = false;
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.RowHeadersWidth = 51;
            this.gridBooks.RowTemplate.Height = 29;
            this.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBooks.Size = new System.Drawing.Size(1010, 491);
            this.gridBooks.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(1028, 104);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(126, 29);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBook.Location = new System.Drawing.Point(1028, 139);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(126, 53);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Изменить книгу";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.Location = new System.Drawing.Point(1028, 198);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(126, 29);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Удалить книгу";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // lblTitleFilter
            // 
            this.lblTitleFilter.AutoSize = true;
            this.lblTitleFilter.Location = new System.Drawing.Point(12, 9);
            this.lblTitleFilter.Name = "lblTitleFilter";
            this.lblTitleFilter.Size = new System.Drawing.Size(80, 20);
            this.lblTitleFilter.TabIndex = 4;
            this.lblTitleFilter.Text = "Название:";
            // 
            // txtTitleFilter
            // 
            this.txtTitleFilter.Location = new System.Drawing.Point(98, 6);
            this.txtTitleFilter.Name = "txtTitleFilter";
            this.txtTitleFilter.Size = new System.Drawing.Size(299, 27);
            this.txtTitleFilter.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(403, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 20);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Автор:";
            // 
            // txtAuthorFilter
            // 
            this.txtAuthorFilter.Location = new System.Drawing.Point(463, 6);
            this.txtAuthorFilter.Name = "txtAuthorFilter";
            this.txtAuthorFilter.Size = new System.Drawing.Size(299, 27);
            this.txtAuthorFilter.TabIndex = 7;
            // 
            // lblGenreFilter
            // 
            this.lblGenreFilter.AutoSize = true;
            this.lblGenreFilter.Location = new System.Drawing.Point(768, 9);
            this.lblGenreFilter.Name = "lblGenreFilter";
            this.lblGenreFilter.Size = new System.Drawing.Size(51, 20);
            this.lblGenreFilter.TabIndex = 8;
            this.lblGenreFilter.Text = "Жанр:";
            // 
            // cmbGenreFilter
            // 
            this.cmbGenreFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenreFilter.FormattingEnabled = true;
            this.cmbGenreFilter.Location = new System.Drawing.Point(825, 6);
            this.cmbGenreFilter.Name = "cmbGenreFilter";
            this.cmbGenreFilter.Size = new System.Drawing.Size(299, 28);
            this.cmbGenreFilter.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 39);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(147, 29);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(165, 39);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(163, 29);
            this.btnResetFilter.TabIndex = 11;
            this.btnResetFilter.Text = "Сбросить фильтр";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.BtnResetFilter_Click);
            // 
            // btnNewBooksList
            // 
            this.btnNewBooksList.Location = new System.Drawing.Point(1028, 278);
            this.btnNewBooksList.Name = "btnNewBooksList";
            this.btnNewBooksList.Size = new System.Drawing.Size(126, 36);
            this.btnNewBooksList.TabIndex = 12;
            this.btnNewBooksList.Text = "Новинки";
            this.btnNewBooksList.UseVisualStyleBackColor = true;
            this.btnNewBooksList.Click += new System.EventHandler(this.BtnNewBooksList_Click);
            // 
            // btnTopSales
            // 
            this.btnTopSales.Location = new System.Drawing.Point(1028, 320);
            this.btnTopSales.Name = "btnTopSales";
            this.btnTopSales.Size = new System.Drawing.Size(126, 29);
            this.btnTopSales.TabIndex = 13;
            this.btnTopSales.Text = "Топ продаж";
            this.btnTopSales.UseVisualStyleBackColor = true;
            this.btnTopSales.Click += new System.EventHandler(this.BtnTopSales_Click);
            // 
            // btnTopAuthors
            // 
            this.btnTopAuthors.Location = new System.Drawing.Point(1028, 355);
            this.btnTopAuthors.Name = "btnTopAuthors";
            this.btnTopAuthors.Size = new System.Drawing.Size(126, 29);
            this.btnTopAuthors.TabIndex = 14;
            this.btnTopAuthors.Text = "Топ авторов";
            this.btnTopAuthors.UseVisualStyleBackColor = true;
            this.btnTopAuthors.Click += new System.EventHandler(this.BtnTopAuthors_Click);
            // 
            // BtnTopGenresWeek
            // 
            this.BtnTopGenresWeek.Location = new System.Drawing.Point(1028, 390);
            this.BtnTopGenresWeek.Name = "BtnTopGenresWeek";
            this.BtnTopGenresWeek.Size = new System.Drawing.Size(126, 54);
            this.BtnTopGenresWeek.TabIndex = 15;
            this.BtnTopGenresWeek.Text = "Топ жанров за неделю";
            this.BtnTopGenresWeek.UseVisualStyleBackColor = true;
            this.BtnTopGenresWeek.Click += new System.EventHandler(this.BtnTopGenresWeek_Click);
            // 
            // btnTopGenresMonth
            // 
            this.btnTopGenresMonth.Location = new System.Drawing.Point(1030, 450);
            this.btnTopGenresMonth.Name = "btnTopGenresMonth";
            this.btnTopGenresMonth.Size = new System.Drawing.Size(124, 55);
            this.btnTopGenresMonth.TabIndex = 16;
            this.btnTopGenresMonth.Text = "Топ жанров за месяц";
            this.btnTopGenresMonth.UseVisualStyleBackColor = true;
            this.btnTopGenresMonth.Click += new System.EventHandler(this.BtnTopGenresMonth_Click);
            // 
            // btnTopGenresYear
            // 
            this.btnTopGenresYear.Location = new System.Drawing.Point(1030, 511);
            this.btnTopGenresYear.Name = "btnTopGenresYear";
            this.btnTopGenresYear.Size = new System.Drawing.Size(124, 60);
            this.btnTopGenresYear.TabIndex = 17;
            this.btnTopGenresYear.Text = "Топ жанров за год";
            this.btnTopGenresYear.UseVisualStyleBackColor = true;
            this.btnTopGenresYear.Click += new System.EventHandler(this.btnTopGenresYear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 607);
            this.Controls.Add(this.btnTopGenresYear);
            this.Controls.Add(this.btnTopGenresMonth);
            this.Controls.Add(this.BtnTopGenresWeek);
            this.Controls.Add(this.btnTopAuthors);
            this.Controls.Add(this.btnTopSales);
            this.Controls.Add(this.btnNewBooksList);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbGenreFilter);
            this.Controls.Add(this.lblGenreFilter);
            this.Controls.Add(this.txtAuthorFilter);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitleFilter);
            this.Controls.Add(this.lblTitleFilter);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.gridBooks);
            this.Name = "MainForm";
            this.Text = "Книжный магазин";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridBooks;
        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnDeleteBook;
        private Label lblTitleFilter;
        private TextBox txtTitleFilter;
        private Label lblAuthor;
        private TextBox txtAuthorFilter;
        private Label lblGenreFilter;
        private ComboBox cmbGenreFilter;
        private Button btnFilter;
        private Button btnResetFilter;
        private Button btnNewBooksList;
        private Button btnTopSales;
        private Button btnTopAuthors;
        private Button BtnTopGenresWeek;
        private Button btnTopGenresMonth;
        private Button btnTopGenresYear;
    }
}