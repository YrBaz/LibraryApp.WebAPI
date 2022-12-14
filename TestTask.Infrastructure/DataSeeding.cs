using TestTask.Domain.Entity;

namespace TestTask.Infrastructure
{
    public class DataSeeding
    {
        public static void Seed(AppDbContext dbContext)
        {
            var books = new List<Book>
            {
                #region Books
                new Book { Id = 1, Author = "J.R.R.Tolkien", Cover = "Image1", Content = "Some content", Genre = "Fantasy", Title = "The Lord Of The Ring" },
                new Book { Id = 2, Author = "A.K. Doil", Cover = "Image2", Content = "Some content", Genre = "Detective", Title = "Sherlock Holmes" },
                new Book { Id = 3, Author = "Jack London", Cover = "Image3", Content = "Some content", Genre = "Drama", Title = "Martin Iden" },
                new Book { Id = 4, Author = "Mark Twain", Cover = "Image4", Content = "Some content", Genre = "Adventure", Title = "Tom Sawyer" },
                new Book { Id = 5, Author = "Joan Roling", Cover = "Image5", Content = "Some content", Genre = "Fantasy", Title = "Harry Potter" },
                new Book { Id = 6, Author = "Jack London", Cover = "Image6", Content = "Some content", Genre = "Adventure", Title = "White Fand" },
                new Book { Id = 7, Author = "Miguel de Cervantes", Cover = "Image6", Content = "Some content", Genre = "Novel", Title = " Don Quixote" },
                new Book { Id = 8, Author = "Gabriel Garcia Marquez", Cover = "Image6", Content = "Some content", Genre = "Novel", Title = " One Hundred Years of Solitude" },
                new Book { Id = 9, Author = "F. Scott Fitzgerald", Cover = "Image6", Content = "Some content", Genre = "Novel", Title = " The Great Gatsby" },
                new Book { Id = 10, Author = "Herman Melville", Cover = "Image6", Content = "Some content", Genre = "Adventure", Title = "Moby Dick" }
                #endregion
            };

            var ratings = new List<Rating>
            {
                #region Ratings
                new Rating { Id = 1, Score = 5, BookId = 1 },
                new Rating { Id = 2, Score = 4, BookId = 1 },
                new Rating { Id = 3, Score = 3, BookId = 1 },
                new Rating { Id = 4, Score = 4, BookId = 1 },
                new Rating { Id = 5, Score = 5, BookId = 1 },
                new Rating { Id = 6, Score = 5, BookId = 1 },
                new Rating { Id = 7, Score = 5, BookId = 1 },
                new Rating { Id = 8, Score = 4, BookId = 1 },
                new Rating { Id = 9, Score = 5, BookId = 1 },
                new Rating { Id = 10, Score = 4, BookId = 1 },
                new Rating { Id = 11, Score = 3, BookId = 1 },
                new Rating { Id = 12, Score = 4, BookId = 1 },
                new Rating { Id = 13, Score = 5, BookId = 2 },
                new Rating { Id = 14, Score = 5, BookId = 2 },
                new Rating { Id = 15, Score = 4, BookId = 2 },
                new Rating { Id = 16, Score = 3, BookId = 2 },
                new Rating { Id = 17, Score = 4, BookId = 2 },
                new Rating { Id = 18, Score = 5, BookId = 2 },
                new Rating { Id = 19, Score = 5, BookId = 2 },
                new Rating { Id = 20, Score = 5, BookId = 2 },
                new Rating { Id = 21, Score = 4, BookId = 2 },
                new Rating { Id = 22, Score = 5, BookId = 2 },
                new Rating { Id = 23, Score = 4, BookId = 2 },
                new Rating { Id = 24, Score = 3, BookId = 3 },
                new Rating { Id = 25, Score = 4, BookId = 3 },
                new Rating { Id = 26, Score = 5, BookId = 3 },
                new Rating { Id = 27, Score = 4, BookId = 3 },
                new Rating { Id = 28, Score = 3, BookId = 3 },
                new Rating { Id = 29, Score = 4, BookId = 3 },
                new Rating { Id = 30, Score = 5, BookId = 3 },
                new Rating { Id = 31, Score = 5, BookId = 3 },
                new Rating { Id = 32, Score = 5, BookId = 3 },
                new Rating { Id = 33, Score = 4, BookId = 3 },
                new Rating { Id = 34, Score = 5, BookId = 3 },
                new Rating { Id = 35, Score = 4, BookId = 3 },
                new Rating { Id = 36, Score = 3, BookId = 3 },
                new Rating { Id = 37, Score = 4, BookId = 3 },
                new Rating { Id = 38, Score = 4, BookId = 4 },
                new Rating { Id = 39, Score = 3, BookId = 4 },
                new Rating { Id = 40, Score = 4, BookId = 4 },
                new Rating { Id = 41, Score = 5, BookId = 4 },
                new Rating { Id = 42, Score = 5, BookId = 4 },
                new Rating { Id = 43, Score = 4, BookId = 4 },
                new Rating { Id = 44, Score = 3, BookId = 4 },
                new Rating { Id = 45, Score = 4, BookId = 4 },
                new Rating { Id = 46, Score = 5, BookId = 4 },
                new Rating { Id = 47, Score = 5, BookId = 4 },
                new Rating { Id = 48, Score = 5, BookId = 4 },
                new Rating { Id = 49, Score = 4, BookId = 5 },
                new Rating { Id = 50, Score = 5, BookId = 5 },
                new Rating { Id = 51, Score = 4, BookId = 5 },
                new Rating { Id = 52, Score = 3, BookId = 5 },
                new Rating { Id = 53, Score = 4, BookId = 5 },
                new Rating { Id = 54, Score = 5, BookId = 5 },
                new Rating { Id = 55, Score = 4, BookId = 5 },
                new Rating { Id = 56, Score = 3, BookId = 5 },
                new Rating { Id = 57, Score = 4, BookId = 5 },
                new Rating { Id = 58, Score = 5, BookId = 5 },
                new Rating { Id = 59, Score = 5, BookId = 5 },
                new Rating { Id = 60, Score = 5, BookId = 5 },
                new Rating { Id = 61, Score = 4, BookId = 6 },
                new Rating { Id = 62, Score = 5, BookId = 6 },
                new Rating { Id = 63, Score = 4, BookId = 6 },
                new Rating { Id = 64, Score = 3, BookId = 6 },
                new Rating { Id = 65, Score = 4, BookId = 6 },
                new Rating { Id = 66, Score = 4, BookId = 6 },
                new Rating { Id = 67, Score = 3, BookId = 6 },
                new Rating { Id = 68, Score = 4, BookId = 6 },
                new Rating { Id = 69, Score = 5, BookId = 6 },
                new Rating { Id = 70, Score = 5, BookId = 6 },
                new Rating { Id = 71, Score = 4, BookId = 6 },
                new Rating { Id = 72, Score = 3, BookId = 7 },
                new Rating { Id = 73, Score = 4, BookId = 7 },
                new Rating { Id = 74, Score = 5, BookId = 7 },
                new Rating { Id = 75, Score = 5, BookId = 7 },
                new Rating { Id = 76, Score = 5, BookId = 7 },
                new Rating { Id = 77, Score = 4, BookId = 7 },
                new Rating { Id = 78, Score = 5, BookId = 7 },
                new Rating { Id = 79, Score = 4, BookId = 7 },
                new Rating { Id = 80, Score = 3, BookId = 7 },
                new Rating { Id = 81, Score = 4, BookId = 7 },
                new Rating { Id = 82, Score = 5, BookId = 8 },
                new Rating { Id = 83, Score = 4, BookId = 8 },
                new Rating { Id = 84, Score = 3, BookId = 8 },
                new Rating { Id = 85, Score = 4, BookId = 8 },
                new Rating { Id = 86, Score = 5, BookId = 8 },
                new Rating { Id = 87, Score = 5, BookId = 8 },
                new Rating { Id = 88, Score = 5, BookId = 8 },
                new Rating { Id = 89, Score = 4, BookId = 8 },
                new Rating { Id = 90, Score = 5, BookId = 8 },
                new Rating { Id = 91, Score = 4, BookId = 8 },
                new Rating { Id = 92, Score = 3, BookId = 8 },
                new Rating { Id = 93, Score = 4, BookId = 8 },
                new Rating { Id = 94, Score = 4, BookId = 9 },
                new Rating { Id = 95, Score = 3, BookId = 9 },
                new Rating { Id = 96, Score = 4, BookId = 9 },
                new Rating { Id = 97, Score = 5, BookId = 9 },
                new Rating { Id = 98, Score = 5, BookId = 9 },
                new Rating { Id = 99, Score = 4, BookId = 9 },
                new Rating { Id = 100, Score = 3, BookId = 9 },
                new Rating { Id = 101, Score = 4, BookId = 9 },
                new Rating { Id = 102, Score = 5, BookId = 9 },
                new Rating { Id = 103, Score = 5, BookId = 9 },
                new Rating { Id = 104, Score = 5, BookId = 9 },
                new Rating { Id = 105, Score = 4, BookId = 9 },
                new Rating { Id = 106, Score = 5, BookId = 10 },
                new Rating { Id = 107, Score = 4, BookId = 10 },
                new Rating { Id = 108, Score = 3, BookId = 10 },
                new Rating { Id = 109, Score = 4, BookId = 10 },
                new Rating { Id = 110, Score = 5, BookId = 10 },
                new Rating { Id = 111, Score = 4, BookId = 10 },
                new Rating { Id = 112, Score = 3, BookId = 10 },
                new Rating { Id = 113, Score = 4, BookId = 10 },
                new Rating { Id = 114, Score = 5, BookId = 10 },
                new Rating { Id = 115, Score = 5, BookId = 10 },
                new Rating { Id = 116, Score = 5, BookId = 10 },
                new Rating { Id = 117, Score = 4, BookId = 10 },
                new Rating { Id = 118, Score = 5, BookId = 10 },
                new Rating { Id = 119, Score = 4, BookId = 10 },
                new Rating { Id = 120, Score = 3, BookId = 10 },
                new Rating { Id = 121, Score = 4, BookId = 10 }
                #endregion
            };

            var reviews = new List<Review>
            {
                #region Reviews
                new Review { Id = 1, Message = "Some text", Reviewer = "Alex", BookId = 1 },
                new Review { Id = 2, Message = "Some text", Reviewer = "John", BookId = 1 },
                new Review { Id = 3, Message = "Some text", Reviewer = "Michael", BookId = 1 },
                new Review { Id = 4, Message = "Some text", Reviewer = "Alice", BookId = 1 },
                new Review { Id = 5, Message = "Some text", Reviewer = "Lize", BookId = 1 },
                new Review { Id = 6, Message = "Some text", Reviewer = "Anny", BookId = 1 },
                new Review { Id = 7, Message = "Some text", Reviewer = "Den", BookId = 1 },
                new Review { Id = 8, Message = "Some text", Reviewer = "Izabel", BookId = 1 },
                new Review { Id = 9, Message = "Some text", Reviewer = "Philippe", BookId = 1 },
                new Review { Id = 10, Message = "Some text", Reviewer = "Didi", BookId = 1 },
                new Review { Id = 11, Message = "Some text", Reviewer = "Alex", BookId = 2 },
                new Review { Id = 12, Message = "Some text", Reviewer = "John", BookId = 2 },
                new Review { Id = 13, Message = "Some text", Reviewer = "Michael", BookId = 2 },
                new Review { Id = 14, Message = "Some text", Reviewer = "Alice", BookId = 2 },
                new Review { Id = 15, Message = "Some text", Reviewer = "Lize", BookId = 2 },
                new Review { Id = 16, Message = "Some text", Reviewer = "Anny", BookId = 2 },
                new Review { Id = 17, Message = "Some text", Reviewer = "Den", BookId = 2 },
                new Review { Id = 18, Message = "Some text", Reviewer = "Izabel", BookId = 2 },
                new Review { Id = 19, Message = "Some text", Reviewer = "Philippe", BookId = 2 },
                new Review { Id = 20, Message = "Some text", Reviewer = "Didi", BookId = 2 },
                new Review { Id = 21, Message = "Some text", Reviewer = "Alex", BookId = 3 },
                new Review { Id = 22, Message = "Some text", Reviewer = "John", BookId = 3 },
                new Review { Id = 23, Message = "Some text", Reviewer = "Michael", BookId = 3 },
                new Review { Id = 24, Message = "Some text", Reviewer = "Alice", BookId = 3 },
                new Review { Id = 25, Message = "Some text", Reviewer = "Lize", BookId = 3 },
                new Review { Id = 26, Message = "Some text", Reviewer = "Anny", BookId = 3 },
                new Review { Id = 27, Message = "Some text", Reviewer = "Den", BookId = 3 },
                new Review { Id = 28, Message = "Some text", Reviewer = "Izabel", BookId = 3 },
                new Review { Id = 29, Message = "Some text", Reviewer = "Philippe", BookId = 3 },
                new Review { Id = 30, Message = "Some text", Reviewer = "Didi", BookId = 3 },
                new Review { Id = 41, Message = "Some text", Reviewer = "Alex", BookId = 4 },
                new Review { Id = 42, Message = "Some text", Reviewer = "John", BookId = 4 },
                new Review { Id = 43, Message = "Some text", Reviewer = "Michael", BookId = 4 },
                new Review { Id = 44, Message = "Some text", Reviewer = "Alice", BookId = 4 },
                new Review { Id = 45, Message = "Some text", Reviewer = "Lize", BookId = 4 },
                new Review { Id = 46, Message = "Some text", Reviewer = "Anny", BookId = 4 },
                new Review { Id = 47, Message = "Some text", Reviewer = "Den", BookId = 4 },
                new Review { Id = 48, Message = "Some text", Reviewer = "Izabel", BookId = 4 },
                new Review { Id = 49, Message = "Some text", Reviewer = "Philippe", BookId = 4 },
                new Review { Id = 50, Message = "Some text", Reviewer = "Didi", BookId = 4 },
                new Review { Id = 51, Message = "Some text", Reviewer = "Alex", BookId = 5 },
                new Review { Id = 52, Message = "Some text", Reviewer = "John", BookId = 5 },
                new Review { Id = 53, Message = "Some text", Reviewer = "Michael", BookId = 5 },
                new Review { Id = 54, Message = "Some text", Reviewer = "Alice", BookId = 5 },
                new Review { Id = 55, Message = "Some text", Reviewer = "Lize", BookId = 5 },
                new Review { Id = 56, Message = "Some text", Reviewer = "Anny", BookId = 5 },
                new Review { Id = 57, Message = "Some text", Reviewer = "Den", BookId = 5 },
                new Review { Id = 58, Message = "Some text", Reviewer = "Izabel", BookId = 5 },
                new Review { Id = 59, Message = "Some text", Reviewer = "Philippe", BookId = 5 },
                new Review { Id = 60, Message = "Some text", Reviewer = "Didi", BookId = 5 },
                new Review { Id = 61, Message = "Some text", Reviewer = "Alex", BookId = 6 },
                new Review { Id = 62, Message = "Some text", Reviewer = "John", BookId = 6 },
                new Review { Id = 63, Message = "Some text", Reviewer = "Michael", BookId = 6 },
                new Review { Id = 64, Message = "Some text", Reviewer = "Alice", BookId = 6 },
                new Review { Id = 65, Message = "Some text", Reviewer = "Lize", BookId = 6 },
                new Review { Id = 66, Message = "Some text", Reviewer = "Anny", BookId = 6 },
                new Review { Id = 67, Message = "Some text", Reviewer = "Den", BookId = 6 },
                new Review { Id = 68, Message = "Some text", Reviewer = "Izabel", BookId = 6 },
                new Review { Id = 69, Message = "Some text", Reviewer = "Philippe", BookId = 6 },
                new Review { Id = 70, Message = "Some text", Reviewer = "Didi", BookId = 6 },
                new Review { Id = 71, Message = "Some text", Reviewer = "Alex", BookId = 7 },
                new Review { Id = 72, Message = "Some text", Reviewer = "John", BookId = 7 },
                new Review { Id = 73, Message = "Some text", Reviewer = "Michael", BookId = 7 },
                new Review { Id = 74, Message = "Some text", Reviewer = "Alice", BookId = 7 },
                new Review { Id = 75, Message = "Some text", Reviewer = "Lize", BookId = 7 },
                new Review { Id = 76, Message = "Some text", Reviewer = "Anny", BookId = 7 },
                new Review { Id = 77, Message = "Some text", Reviewer = "Den", BookId = 7 },
                new Review { Id = 78, Message = "Some text", Reviewer = "Izabel", BookId = 7 },
                new Review { Id = 79, Message = "Some text", Reviewer = "Philippe", BookId = 7 },
                new Review { Id = 80, Message = "Some text", Reviewer = "Didi", BookId = 7 },
                new Review { Id = 81, Message = "Some text", Reviewer = "Alex", BookId = 8 },
                new Review { Id = 82, Message = "Some text", Reviewer = "John", BookId = 8 },
                new Review { Id = 83, Message = "Some text", Reviewer = "Michael", BookId = 8 },
                new Review { Id = 84, Message = "Some text", Reviewer = "Alice", BookId = 8 },
                new Review { Id = 85, Message = "Some text", Reviewer = "Lize", BookId = 8 },
                new Review { Id = 86, Message = "Some text", Reviewer = "Anny", BookId = 8 },
                new Review { Id = 87, Message = "Some text", Reviewer = "Den", BookId = 8 },
                new Review { Id = 88, Message = "Some text", Reviewer = "Izabel", BookId = 8 },
                new Review { Id = 89, Message = "Some text", Reviewer = "Philippe", BookId = 8 },
                new Review { Id = 90, Message = "Some text", Reviewer = "Didi", BookId = 8 },
                new Review { Id = 91, Message = "Some text", Reviewer = "Alex", BookId = 9 },
                new Review { Id = 92, Message = "Some text", Reviewer = "John", BookId = 9 },
                new Review { Id = 93, Message = "Some text", Reviewer = "Michael", BookId = 9 },
                new Review { Id = 94, Message = "Some text", Reviewer = "Alice", BookId = 9 },
                new Review { Id = 95, Message = "Some text", Reviewer = "Lize", BookId = 9 },
                new Review { Id = 96, Message = "Some text", Reviewer = "Anny", BookId = 9 },
                new Review { Id = 97, Message = "Some text", Reviewer = "Den", BookId = 9 },
                new Review { Id = 98, Message = "Some text", Reviewer = "Izabel", BookId = 9 },
                new Review { Id = 99, Message = "Some text", Reviewer = "Philippe", BookId = 9 },
                new Review { Id = 100, Message = "Some text", Reviewer = "Didi", BookId = 9 },
                new Review { Id = 101, Message = "Some text", Reviewer = "Alex", BookId = 10 },
                new Review { Id = 102, Message = "Some text", Reviewer = "John", BookId = 10 },
                new Review { Id = 103, Message = "Some text", Reviewer = "Michael", BookId = 10 },
                new Review { Id = 104, Message = "Some text", Reviewer = "Alice", BookId = 10 },
                new Review { Id = 105, Message = "Some text", Reviewer = "Lize", BookId = 10 },
                new Review { Id = 106, Message = "Some text", Reviewer = "Anny", BookId = 10 },
                new Review { Id = 107, Message = "Some text", Reviewer = "Den", BookId = 10 },
                new Review { Id = 108, Message = "Some text", Reviewer = "Izabel", BookId = 10 },
                new Review { Id = 109, Message = "Some text", Reviewer = "Philippe", BookId = 10 },
                new Review { Id = 110, Message = "Some text", Reviewer = "Didi", BookId = 10 },
                new Review { Id = 111, Message = "Some text", Reviewer = "Alex", BookId = 1 },
                new Review { Id = 112, Message = "Some text", Reviewer = "John", BookId = 2 },
                new Review { Id = 113, Message = "Some text", Reviewer = "Michael", BookId = 3 },
                new Review { Id = 114, Message = "Some text", Reviewer = "Alice", BookId = 4 },
                new Review { Id = 115, Message = "Some text", Reviewer = "Lize", BookId = 5 },
                new Review { Id = 116, Message = "Some text", Reviewer = "Anny", BookId = 6 },
                new Review { Id = 117, Message = "Some text", Reviewer = "Den", BookId = 7 },
                new Review { Id = 118, Message = "Some text", Reviewer = "Izabel", BookId = 8 },
                new Review { Id = 119, Message = "Some text", Reviewer = "Philippe", BookId = 9 },
                new Review { Id = 120, Message = "Some text", Reviewer = "Didi", BookId = 10 }
                #endregion
            };

            dbContext.AddRange(books);
            dbContext.AddRange(ratings);
            dbContext.AddRange(reviews);

            dbContext.SaveChanges();
        }
    }
}