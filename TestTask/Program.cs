using TestTask.Application;
using TestTask.Application.Common;
using TestTask.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplication(builder.Configuration);
    builder.Services.AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();

    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

{
    app.UseMiddleware<ErrorHandlerMiddleware>();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}