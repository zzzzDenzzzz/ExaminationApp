using ExaminationApp.Entities;
using ExaminationApp.Forms;
using ExaminationApp.Helpers;
using ExaminationApp.Services;

namespace ExaminationApp
{
    public partial class MainForm : Form
    {
        private readonly BookStoreService _bookStoreService;
        public MainForm()
        {
            _bookStoreService = new();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WinFormsHelper.PopulateGenresComboBox(cmbGenreFilter);
            ShowBooks();
        }

        private async void ShowBooks()
        {
            WinFormsHelper.ShowTable(
                gridBooks,
                WinFormsHelper.CreateBooksTable(await _bookStoreService.GetAllBooksAsync()));
        }

        private void ShowBooks(List<Book> books)
        {
            WinFormsHelper.ShowTable(
                gridBooks,
                WinFormsHelper.CreateBooksTable(books));
        }

        private async void BtnAddBook_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditBookForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _bookStoreService.AddBookAsync(form.Title, form.Author, form.Publisher, form.Genre, form.PagesCount, form.YearPublished, form.Price);
                ShowBooks();
            }
        }

        private async void BtnEditBook_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count > 0)
            {
                var bookId = int.Parse(gridBooks.SelectedRows[0].Cells[0].Value.ToString()!);
                var book = await _bookStoreService.GetBookByIdAsync(bookId);

                if (book == null)
                {
                    MessageBox.Show("Книга не найдена");
                    ShowBooks();
                }
                else
                {
                    try
                    {
                        var form = new AddOrEditBookForm(book);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            await _bookStoreService.EditBookAsync(book, form.Title, form.Author, form.Publisher, form.Genre, form.PagesCount, form.YearPublished, form.Price);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        ShowBooks();
                    }
                }
            }
        }

        private async void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count > 0)
            {
                var bookId = int.Parse(gridBooks.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _bookStoreService.DeleteBookAsync(bookId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ShowBooks();
                }
            }
            else
            {
                MessageBox.Show("Книга не найдена");
            }
        }

        private async void BtnFilter_Click(object sender, EventArgs e)
        {
            ShowBooks(await _bookStoreService.FilterBooksAsync(txtAuthorFilter.Text.Trim(), txtTitleFilter.Text.Trim(), (int)cmbGenreFilter.SelectedValue));
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            txtAuthorFilter.Text = string.Empty;
            txtTitleFilter.Text = string.Empty;
            cmbGenreFilter.SelectedItem = cmbGenreFilter.Items[0];
            ShowBooks();
        }

        private async void BtnNewBooksList_Click(object sender, EventArgs e)
        {
            ShowBooks(await _bookStoreService.GetNewBooksListAsync());
        }

        private async void BtnTopSales_Click(object sender, EventArgs e)
        {
            ShowBooks(await _bookStoreService.GetTopSalesAsync());
        }

        private async void BtnTopAuthors_Click(object sender, EventArgs e)
        {
            WinFormsHelper.ShowTable(
                gridBooks,
                WinFormsHelper.CreateOneColumnTable(await _bookStoreService.GetTopAuthorsAsync(), "Автор"),
                false);
        }

        private async void BtnTopGenresWeek_Click(object sender, EventArgs e)
        {
            var genres = await _bookStoreService.GetTopGenresAsync(7);
            WinFormsHelper.ShowTable(
                gridBooks,
                WinFormsHelper.CreateOneColumnTable(genres.Select(x => x.GetEnumDescription()).ToList(), "Жанр"),
                false);
        }

        private async void BtnTopGenresMonth_Click(object sender, EventArgs e)
        {
            var genres = await _bookStoreService.GetTopGenresAsync(30);
            WinFormsHelper.ShowTable(
                gridBooks,
                WinFormsHelper.CreateOneColumnTable(genres.Select(x => x.GetEnumDescription()).ToList(), "Жанр"),
                false);
        }

        private async void btnTopGenresYear_Click(object sender, EventArgs e)
        {
            var genres = await _bookStoreService.GetTopGenresAsync(365);
            WinFormsHelper.ShowTable(
                gridBooks,
                WinFormsHelper.CreateOneColumnTable(genres.Select(x => x.GetEnumDescription()).ToList(), "Жанр"),
                false);
        }
    }
}