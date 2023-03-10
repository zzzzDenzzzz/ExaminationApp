using ExaminationApp.Constants;
using ExaminationApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExaminationApp.Services
{
    public class BookStoreService
    {
        private BookStoreContext _context;
        public BookStoreService() 
        {
            _context = new BookStoreContext();
        }

        // Взять все книги из базы
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        // Получить книгу по Id
        public async Task<Book?> GetBookByIdAsync(int bookId)
        {
            return await _context.Books.FindAsync(bookId);
        }

        // Добавить книгу
        public async Task AddBookAsync(string title, string author, string publisher, BookGenre genre, int pagesCount, int yearPublished, decimal price)
        {
            var book = new Book
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                Genre = genre,
                PagesCount = pagesCount,
                PublishYear = yearPublished,
                Price = price,
            };

            await _context.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        // Изменить книгу
        public async Task EditBookAsync(Book book, string title, string author, string publisher,
            BookGenre genre, int pagesCount, int yearPublished, decimal price)
        {
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.Genre = genre;
            book.PagesCount = pagesCount;
            book.PublishYear = yearPublished;
            book.Price = price;
            await _context.SaveChangesAsync();
        }

        // Удалить книгу
        public async Task DeleteBookAsync(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                if (book.SoldBooks != null && book.SoldBooks.Any())
                {
                    throw new Exception("Удаление невозможно");
                }

                _context.Remove(book);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("ОбЪект не найден");
            }
        }

        // Отфильтровать книги
        public async Task<List<Book>> FilterBooksAsync(string author, string title, int bookGenre)
        {
            return await _context.Books
                .Where(b => b.Author == author && b.Title == title && ((int)b.Genre) == bookGenre && bookGenre != 0)
                .ToListAsync();
        }

        // Взять список новинок. Книги изданные за последние 5 лет
        public async Task<List<Book>> GetNewBooksListAsync(int years = 5)
        {
            var currentYear = DateTime.Now.Year;
            return await _context.Books
                .Where(b => b.PublishYear > (currentYear - years))
                .ToListAsync();
        }

        // Взять топ продаж. Первые 3 книги по кол-ву проданных экземпляров
        public async Task<List<Book>> GetTopSalesAsync(int top = 3)
        {
            return await _context.Books
                .OrderByDescending(x => x.SoldBooks.Sum(b => b.SoldAmount))
                .Take(top)
                .ToListAsync();
        }

        // Взять топ авторов. Первые 3 автора по продажам их книг
        public async Task<List<string>> GetTopAuthorsAsync(int top = 3)
        {
            return await _context.Books
                .GroupBy(b => b.Author)
                .OrderByDescending(x => x.SelectMany(c => c.SoldBooks).Sum(b => b.SoldAmount))
                .Take(top)
                .Select(x => x.Key)
                .ToListAsync();
        }

        // Взять топ жанров за сколько-то дней. Первые 3 жанра по продажам их книг
        public async Task<List<BookGenre>> GetTopGenresAsync(int days, int top = 3)
        {
            var now = DateTime.Now;
            var timeNeeded = now.AddDays(-days);

            return await _context.Books
                .GroupBy(b => b.Genre)
                .OrderByDescending(x => x.SelectMany(c => c.SoldBooks
                    .Where(b => b.SellingDate >= timeNeeded))
                .Sum(b => b.SoldAmount))
                .Take(top)
                .Select(x => x.Key)
                .ToListAsync();
        }
    }
}
