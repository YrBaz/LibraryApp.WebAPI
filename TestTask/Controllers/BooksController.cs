using Microsoft.AspNetCore.Mvc;
using TestTask.Application;
using TestTask.Contracts.DTO;

namespace TestTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks([FromQuery] string order, [FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            var bookItems = await _bookService.GetAllBooks(order, skip, take);

            return Ok(bookItems);
        }

        [HttpGet("/api/recommended")]
        public async Task<IActionResult> GetRecommendedBooks([FromQuery] string genre, [FromQuery] int take = 10)
        {
            var bookItems = await _bookService.GetRecommendedBooks(genre, take);

            return Ok(bookItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookFullinfo([FromRoute] int id)
        {
            var bookInfo = await _bookService.GetBookFullinfo(id);

            if (bookInfo == null)
            {
                return NotFound();
            }

            return Ok(bookInfo);
        }

        [HttpPost("save")]
        public async Task<IActionResult> CreateBook([FromBody] BookSavingDto bookSavingDto)
        {
            var result = await _bookService.SaveBook(bookSavingDto);

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id, [FromQuery] string secret)
        {
            await _bookService.DeleteBook(id, secret);
            
            return NoContent();
        }

        [HttpPost("{id}/review")]
        public async Task<IActionResult> CreateReview([FromRoute] int id, [FromBody] ReviewDetailDto model)
        {
            var result = await _bookService.CreateReview(id, model);

            return Ok(result);
        }

        [HttpPost("{id}/rating")]
        public async Task<IActionResult> CreateRating([FromRoute] int id, [FromBody] RateDto model)
        {
            var result = await _bookService.CreateRating(id, model);
            return Ok(result);
        }
    }
}