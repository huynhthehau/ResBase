using Microsoft.AspNetCore.Mvc.Infrastructure;
using RestaurantManager.Api.Errors;
using RestaurantManager.Api.Filters;
using RestaurantManager.Api.MIddlewares;
using RestaurantManager.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{

    // Add services to the container.
    builder.Services.AddInfrastructure(builder.Configuration);
    //builder.Services.AddControllers(options =>options.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddSingleton<ProblemDetailsFactory, RestaurantProblemDetailsFactory>();
}
var app = builder.Build();
{

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    //app.UseMiddleware<ErrorHandlingMiddleware>();

    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}