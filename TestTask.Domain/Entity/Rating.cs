namespace TestTask.Domain.Entity
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}