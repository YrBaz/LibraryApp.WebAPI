using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Application.Common.Validation;
using TestTask.Contracts.DTO;

namespace TestTask.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            var applicationConfiguration = new ApplicationConfiguration();
            configuration.Bind(applicationConfiguration);
            services.AddSingleton(applicationConfiguration);

            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IValidator<RateDto>, RateDtoValidator>();
            services.AddScoped<IValidator<BookSavingDto>, BookSavingDtoValidator>();

            return services;
        }
    }
}