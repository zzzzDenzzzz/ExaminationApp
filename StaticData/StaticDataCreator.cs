using ExaminationApp.Constants;
using ExaminationApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExaminationApp.StaticData
{
    public class StaticDataCreator
    {
        public static void CreateBooks(ModelBuilder builder)
        {
            builder.Entity<Book>()
               .HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "Гарри Поттер и философский камень",
                        Author = "Джоан Роулинг",
                        Genre = BookGenre.Fantasy,
                        Publisher = "Росмэн",
                        PagesCount = 600,
                        PublishYear = 2000,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Сумма технологий",
                        Author = "Станислав Лем",
                        Genre = BookGenre.Philosophy,
                        Publisher = "АСТ",
                        PagesCount = 640,
                        PublishYear = 2018,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "Задача трех тел",
                        Author = "Лю Цысинь",
                        Genre = BookGenre.ScienceFiction,
                        Publisher = "Fanzon",
                        PagesCount = 440,
                        PublishYear = 2017,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "Темный лес",
                        Author = "Лю Цысинь",
                        Genre = BookGenre.ScienceFiction,
                        Publisher = "Fanzon",
                        PagesCount = 650,
                        PublishYear = 2018,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 5,
                        Title = "Имя розы",
                        Author = "Умберто Эко",
                        Genre = BookGenre.Detective,
                        Publisher = "Corpus",
                        PagesCount = 710,
                        PublishYear = 1980,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 6,
                        Title = "Скандал столетия",
                        Author = "Габриэль Гарсия Маркес",
                        Genre = BookGenre.Detective,
                        Publisher = "Corpus",
                        PagesCount = 330,
                        PublishYear = 2022,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 7,
                        Title = "Снова мечтай",
                        Author = "Мона Кастен",
                        Genre = BookGenre.LoveStory,
                        Publisher = "Like Book",
                        PagesCount = 400,
                        PublishYear = 2023,
                        Price = 500
                    },
                    new Book
                    {
                        Id = 8,
                        Title = "Бригады призраков",
                        Author = "Джон Скальци",
                        Genre = BookGenre.ScienceFiction,
                        Publisher = "Fanzon",
                        PagesCount = 380,
                        PublishYear = 2022,
                        Price = 500
                    }
               );
        }

        public static void CreateSoldBooks(ModelBuilder builder)
        {
            builder.Entity<SoldBook>()
                .HasData(
                    new SoldBook
                    {
                        Id = 1,
                        SellingDate = new DateTime(2010, 1, 1),
                        SoldAmount = 1000,
                        BookId = 1
                    },
                    new SoldBook
                    {
                        Id = 2,
                        SellingDate = new DateTime(2019, 1, 1),
                        SoldAmount = 500,
                        BookId = 2
                    },
                    new SoldBook
                    {
                        Id = 3,
                        SellingDate = new DateTime(2018, 1, 1),
                        SoldAmount = 10000,
                        BookId = 3
                    },
                    new SoldBook
                    {
                        Id = 4,
                        SellingDate = new DateTime(2019, 1, 1),
                        SoldAmount = 5000,
                        BookId = 4
                    },
                    new SoldBook
                    {
                        Id = 5,
                        SellingDate = new DateTime(1990, 1, 1),
                        SoldAmount = 100000,
                        BookId = 5
                    },
                    new SoldBook
                    {
                        Id = 6,
                        SellingDate = new DateTime(2022, 1, 1),
                        SoldAmount = 10000,
                        BookId = 6
                    },
                    new SoldBook
                    {
                        Id = 7,
                        SellingDate = new DateTime(2023, 1, 1),
                        SoldAmount = 100,
                        BookId = 7
                    },
                    new SoldBook
                    {
                        Id = 8,
                        SellingDate = new DateTime(2022, 1, 1),
                        SoldAmount = 1000,
                        BookId = 8
                    }
                );
        }
    }
}
