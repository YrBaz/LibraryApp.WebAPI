using AutoMapper;
using TestTask.Contracts.DTO;
using TestTask.Domain.Entity;

namespace TestTask.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookSavingDto, Book>();

            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Rating,
                    opt => opt.MapFrom(
                        src => (decimal)(src.Ratings.Any() ? src.Ratings.Average(i => i.Score) : 0)))
                .ForMember(dest => dest.ReviewNumber,
                    opt => opt.MapFrom(src => (decimal)src.Reviews.Count()));

            CreateMap<Book, BookFullInfoDto>()
                .ForMember(dest => dest.Rating,
                    opt => opt.MapFrom(
                        src => (decimal)(src.Ratings.Any() ? src.Ratings.Average(i => i.Score) : 0)));

            CreateMap<Review, ReviewDto>();
        }
    }
}