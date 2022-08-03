using Microsoft.EntityFrameworkCore;
using TestTask.Application;
using TestTask.Domain.Entity;

namespace TestTask.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _dbContext;
        public BookRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Book> GetBooks()
        {
            return _dbContext.Books.Include(e => e.Ratings).Include(e => e.Reviews);
        }


        public async Task<int> CreateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }

        public async Task<int> UpdateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _dbContext.Books.Update(book);
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }

        public async Task DeleteBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _dbContext.Remove(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> CreateReview(Review review)
        {
            if (review == null)
            {
                throw new ArgumentNullException(nameof(review));
            }

            _dbContext.Reviews.Add(review);
            await _dbContext.SaveChangesAsync();

            return review.Id;
        }

        public async Task<int> CreateRating(Rating rating)
        {
            if (rating == null)
            {
                throw new ArgumentNullException(nameof(rating));
            }

            _dbContext.Ratings.Add(rating);
            await _dbContext.SaveChangesAsync();

            return rating.Id;
        }
    }
}