using TestTask.Domain.Entity;

namespace TestTask.Application
{
    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();
        Task<int> CreateBook(Book book);
        Task<int> UpdateBook(Book book);
        Task DeleteBook(Book book);
        Task<int> CreateReview(Review review);
        Task<int> CreateRating(Rating rating);
    }
}