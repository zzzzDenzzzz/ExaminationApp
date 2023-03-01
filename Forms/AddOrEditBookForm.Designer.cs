namespace ExaminationApp.Forms
{
    partial class AddOrEditBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.numericPagesCount = new System.Windows.Forms.NumericUpDown();
            this.lblPagesCount = new System.Windows.Forms.Label();
            this.numericYearPublished = new System.Windows.Forms.NumericUpDown();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPublisher = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGenre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPagesCount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorYearPublished = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericPagesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPagesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYearPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(102, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(425, 27);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTitle_Validating);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 42);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 20);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(102, 39);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(425, 27);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAuthor_Validating);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(102, 72);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(425, 27);
            this.txtPublisher.TabIndex = 4;
            this.txtPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPublisher_Validating);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 75);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(76, 20);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "Издатель:";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(102, 105);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(425, 28);
            this.cmbGenre.TabIndex = 6;
            this.cmbGenre.Validating += new System.ComponentModel.CancelEventHandler(this.CmbGenre_Validating);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 108);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(51, 20);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Жанр:";
            // 
            // numericPagesCount
            // 
            this.numericPagesCount.Location = new System.Drawing.Point(140, 139);
            this.numericPagesCount.Name = "numericPagesCount";
            this.numericPagesCount.Size = new System.Drawing.Size(150, 27);
            this.numericPagesCount.TabIndex = 8;
            this.numericPagesCount.Validating += new System.ComponentModel.CancelEventHandler(this.NumericPagesCount_Validating);
            // 
            // lblPagesCount
            // 
            this.lblPagesCount.AutoSize = true;
            this.lblPagesCount.Location = new System.Drawing.Point(12, 141);
            this.lblPagesCount.Name = "lblPagesCount";
            this.lblPagesCount.Size = new System.Drawing.Size(122, 20);
            this.lblPagesCount.TabIndex = 9;
            this.lblPagesCount.Text = "Кол-во страниц:";
            // 
            // numericYearPublished
            // 
            this.numericYearPublished.Location = new System.Drawing.Point(140, 172);
            this.numericYearPublished.Name = "numericYearPublished";
            this.numericYearPublished.Size = new System.Drawing.Size(150, 27);
            this.numericYearPublished.TabIndex = 10;
            this.numericYearPublished.Validating += new System.ComponentModel.CancelEventHandler(this.NumericYearPublished_Validating);
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Location = new System.Drawing.Point(12, 174);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(98, 20);
            this.lblYearPublished.TabIndex = 11;
            this.lblYearPublished.Text = "Год издания:";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(140, 205);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(150, 27);
            this.numericPrice.TabIndex = 12;
            this.numericPrice.Validating += new System.ComponentModel.CancelEventHandler(this.NumericPrice_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 207);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Цена: ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(433, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorTitle
            // 
            this.errorTitle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTitle.ContainerControl = this;
            // 
            // errorAuthor
            // 
            this.errorAuthor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAuthor.ContainerControl = this;
            // 
            // errorPublisher
            // 
            this.errorPublisher.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPublisher.ContainerControl = this;
            // 
            // errorGenre
            // 
            this.errorGenre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorGenre.ContainerControl = this;
            // 
            // errorPagesCount
            // 
            this.errorPagesCount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPagesCount.ContainerControl = this;
            // 
            // errorYearPublished
            // 
            this.errorYearPublished.ContainerControl = this;
            // 
            // errorPrice
            // 
            this.errorPrice.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPrice.ContainerControl = this;
            // 
            // AddOrEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(568, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.lblYearPublished);
            this.Controls.Add(this.numericYearPublished);
            this.Controls.Add(this.lblPagesCount);
            this.Controls.Add(this.numericPagesCount);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddOrEditBookForm";
            this.Text = "Добавить книгу";
            ((System.ComponentModel.ISupportInitialize)(this.numericPagesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPagesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYearPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private Label lblPublisher;
        private ComboBox cmbGenre;
        private Label lblGenre;
        private NumericUpDown numericPagesCount;
        private Label lblPagesCount;
        private NumericUpDown numericYearPublished;
        private Label lblYearPublished;
        private NumericUpDown numericPrice;
        private Label lblPrice;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorTitle;
        private ErrorProvider errorAuthor;
        private ErrorProvider errorPublisher;
        private ErrorProvider errorGenre;
        private ErrorProvider errorPagesCount;
        private ErrorProvider errorYearPublished;
        private ErrorProvider errorPrice;
    }
}