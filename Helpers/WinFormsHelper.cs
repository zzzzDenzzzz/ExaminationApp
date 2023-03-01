using ExaminationApp.Constants;
using ExaminationApp.Entities;
using System.Data;

namespace ExaminationApp.Helpers
{
    public class WinFormsHelper
    {
        public static void PopulateGenresComboBox(ComboBox combobox, BookGenre? genre = null)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new("Не выбран", 0)
            };

            pairs.AddRange(Enum.GetValues<BookGenre>().Select(e => new KeyValuePair<string, int>(e.GetEnumDescription(), (int)e)));
            combobox.DisplayMember = "Key";
            combobox.ValueMember = "Value";
            combobox.DataSource = pairs;
            if (genre != null)
            {
                combobox.SelectedItem = pairs.First(x => x.Value == (int)genre);
            }
        }

        public static DataTable CreateBooksTable(List<Book> books)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название");
            table.Columns.Add("Автор");
            table.Columns.Add("Жанр");
            table.Columns.Add("Год издания");
            table.Columns.Add("Кол-во страниц");
            table.Columns.Add("Цена");

            foreach (var book in books)
            {
                DataRow row = table.NewRow();
                row[0] = book.Id;
                row[1] = book.Title;
                row[2] = book.Author;
                row[3] = book.Genre.GetEnumDescription();
                row[4] = book.PublishYear;
                row[5] = book.PagesCount;
                row[6] = book.Price;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable CreateOneColumnTable(List<string> data, string title)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add(title);

            foreach (var element in data)
            {
                DataRow row = table.NewRow();
                row[0] = element;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void ShowTable(DataGridView grid, DataTable table, bool hideId = true)
        {
            grid.DataSource = null;
            grid.DataSource = table;
            if (hideId)
            {
                grid.Columns[0].Visible = false;
            }
        }
    }
}
