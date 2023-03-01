using ExaminationApp.Constants;

namespace ExaminationApp.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenre Genre { get; set; }
        public string Publisher { get; set; }
        public int PagesCount { get; set; }
        public int PublishYear { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<SoldBook> SoldBooks { get; set; }
    }
}
