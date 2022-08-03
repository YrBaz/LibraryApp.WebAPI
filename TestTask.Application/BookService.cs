using TestTask.Contracts.DTO;
using Microsoft.EntityFrameworkCore;
using TestTask.Domain.Entity;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using TestTask.Application.Common.Exceptions;
using System.Net;
using FluentValidation;

namespace TestTask.Application
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly ApplicationConfiguration _config;
        private readonly IValidator<RateDto> _rateDtoValidator;
        private readonly IValidator<BookSavingDto> _bookSavingDtoValidator;

        public BookService(
            IBookRepository bookRepository,
            IMapper mapper,
            ApplicationConfiguration config,
            IValidator<RateDto> rateDtoValidator,
            IValidator<BookSavingDto> bookSavingDtoValidator
        )
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _config = config;
            _rateDtoValidator = rateDtoValidator;
            _bookSavingDtoValidator = bookSavingDtoValidator;
        }

        public Task<BookDto[]> GetAllBooks(string orderBy, int skip, int take)
        {
            var result = _bookRepository.GetBooks()
                .OrderBy(e => orderBy == "title" ? e.Title : e.Author)
                .Skip(skip)
                .Take(take)
                .ProjectTo<BookDto>(_mapper.ConfigurationProvider)
                .ToArrayAsync();

            return result;
        }

        public Task<BookDto[]> GetRecommendedBooks(string genre, int take)
        {
            var result = _bookRepository.GetBooks()
                .Where(e => e.Genre.ToLower().Contains(genre.ToLower()))
                .ProjectTo<BookDto>(_mapper.ConfigurationProvider)
                .OrderByDescending(e => e.Rating)
                .Where(e => e.ReviewNumber > 10)
                .Take(take)
                .OrderBy(e => e.Rating)
                .ToArrayAsync();

            return result;
        }

        public Task<BookFullInfoDto> GetBookFullinfo(int id)
        {
            var result = _bookRepository.GetBooks()
                .ProjectTo<BookFullInfoDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(e => e.Id == id);

            return result; 
        }

        public async Task<int> SaveBook(BookSavingDto model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var bookModel = _mapper.Map<Book>(model);

            if(bookModel.Id == 0)
            {
                return await _bookRepository.CreateBook(bookModel);
            }

            return await _bookRepository.UpdateBook(bookModel);
        }

        public async Task DeleteBook(int id, string secret)
        {
            if(secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            if(secret != _config.Secret)
            {
                throw new CustomException("Wrong secret", HttpStatusCode.BadRequest);
            }

            var result = await _bookRepository.GetBooks().FirstOrDefaultAsync(e => e.Id == id);

            if (result == null)
            {
                throw new CustomException("Book not found", HttpStatusCode.NotFound);
            }

            await _bookRepository.DeleteBook(result);
        }

        public async Task<int> CreateReview(int id, ReviewDetailDto model)
        {
            var book = await _bookRepository.GetBooks().FirstOrDefaultAsync(e => e.Id == id);

            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            var review = new Review 
            {
                Message = model.Message,
                Reviewer = model.Reviewer,
                BookId = book.Id
            };

            return await _bookRepository.CreateReview(review);
        }

        public async Task<int> CreateRating(int id, RateDto model)
        {
            var validationResult = await _rateDtoValidator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var error = validationResult.Errors[0].ErrorMessage;

                throw new CustomException(error, HttpStatusCode.BadRequest);
            }

            var book = await _bookRepository.GetBooks().FirstOrDefaultAsync(e => e.Id == id);

            if (book == null)
            {
                throw new CustomException("Book not found", HttpStatusCode.NotFound);
            }

            var rating = new Rating
            {
                Score = model.Score
            };

            return await _bookRepository.CreateRating(rating);
        }
    }
}