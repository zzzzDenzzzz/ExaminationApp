namespace ExaminationApp.Entities
{
    public class SoldBook
    {
        public int Id { get; set; }
        public DateTime SellingDate { get; set; }
        public int SoldAmount { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
