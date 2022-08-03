using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Application;

namespace TestTask.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var dbName = configuration.GetValue<string>("DbName");
            services.AddDbContext<AppDbContext>(o => o.UseInMemoryDatabase(dbName));

            var dbContext = services.BuildServiceProvider().GetRequiredService<AppDbContext>();
            DataSeeding.Seed(dbContext);

            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}