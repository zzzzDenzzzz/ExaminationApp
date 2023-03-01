using ExaminationApp.Constants;
using ExaminationApp.Entities;
using ExaminationApp.Helpers;
using System.ComponentModel;

namespace ExaminationApp.Forms
{
    public partial class AddOrEditBookForm : Form
    {
        public string Title => txtTitle.Text.Trim();
        public string Author => txtAuthor.Text.Trim();
        public string Publisher => txtPublisher.Text.Trim();
        public BookGenre Genre => (BookGenre)cmbGenre.SelectedValue;
        public int PagesCount => (int)numericPagesCount.Value;
        public int YearPublished => (int)numericYearPublished.Value;
        public decimal Price => numericPrice.Value;

        public AddOrEditBookForm()
        {
            InitializeComponent();
            WinFormsHelper.PopulateGenresComboBox(cmbGenre);
        }

        public AddOrEditBookForm(Book book)
        {
            InitializeComponent();
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtPublisher.Text = book.Publisher;
            numericPagesCount.Value = book.PagesCount;
            numericYearPublished.Value = book.PublishYear;
            numericPrice.Value = book.Price;
            WinFormsHelper.PopulateGenresComboBox(cmbGenre, book.Genre);
        }

        private void TxtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitle.Text.Trim().Length > DatabaseDefaults.StringLength)
            {
                errorTitle.SetError(txtTitle, "Слишком длинное название");
                e.Cancel = true;
            }
            else
            {
                errorTitle.SetError(txtTitle, string.Empty);
                e.Cancel = false;
            }
        }

        private void TxtAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (txtAuthor.Text.Trim().Length > DatabaseDefaults.StringLength)
            {
                errorAuthor.SetError(txtAuthor, "Слишком длинное имя автора");
                e.Cancel = true;
            }
            else
            {
                errorAuthor.SetError(txtAuthor, string.Empty);
                e.Cancel = false;
            }
        }

        private void TxtPublisher_Validating(object sender, CancelEventArgs e)
        {
            if (txtPublisher.Text.Trim().Length > DatabaseDefaults.StringLength)
            {
                errorPublisher.SetError(txtPublisher, "Слишком длинное название издателя");
                e.Cancel = true;
            }
            else
            {
                errorPublisher.SetError(txtPublisher, string.Empty);
                e.Cancel = false;
            }
        }

        private void CmbGenre_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cmbGenre.SelectedValue! == 0)
            {
                errorGenre.SetError(cmbGenre, "Выберите жанр");
                e.Cancel = true;
            }
            else
            {
                errorGenre.SetError(cmbGenre, string.Empty);
                e.Cancel = false;
            }
        }

        private void NumericPagesCount_Validating(object sender, CancelEventArgs e)
        {
            if (numericPagesCount.Value <= 0)
            {
                errorPagesCount.SetError(numericPagesCount, "Неверное кол-во страниц");
                e.Cancel = true;
            }
            else
            {
                errorPagesCount.SetError(numericPagesCount, string.Empty);
                e.Cancel = false;
            }
        }

        private void NumericYearPublished_Validating(object sender, CancelEventArgs e)
        {
            if (numericYearPublished.Value < 0 || numericYearPublished.Value > DateTime.Now.Year)
            {
                errorYearPublished.SetError(numericYearPublished, "Неверный год издания");
                e.Cancel = true;
            }
            else
            {
                errorYearPublished.SetError(numericYearPublished, string.Empty);
                e.Cancel = false;
            }
        }

        private void NumericPrice_Validating(object sender, CancelEventArgs e)
        {
            if (numericPrice.Value <= 0)
            {
                errorPrice.SetError(numericPrice, "Неверная цена");
                e.Cancel = true;
            }
            else
            {
                errorPrice.SetError(numericPrice, string.Empty);
                e.Cancel = false;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
