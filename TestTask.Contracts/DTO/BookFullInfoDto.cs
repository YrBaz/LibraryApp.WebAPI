namespace TestTask.Contracts.DTO
{
    public class BookFullInfoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Cover { get; set; }
        public string Content { get; set; }
        public decimal Rating { get; set; }
        public List<ReviewDto> Reviews { get; set; }
    }
}