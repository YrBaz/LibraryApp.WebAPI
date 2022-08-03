using TestTask.Contracts.DTO;

namespace TestTask.Application
{
    public interface IBookService
    {
        Task<BookDto[]> GetAllBooks(string orderBy, int skip, int take);
        Task<BookDto[]> GetRecommendedBooks(string genre, int take);
        Task<BookFullInfoDto> GetBookFullinfo(int id);
        Task<int> SaveBook(BookSavingDto model);
        Task DeleteBook(int id, string secret);
        Task<int> CreateReview(int id, ReviewDetailDto model);
        Task<int> CreateRating(int id, RateDto model);
    }
}