using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.MiddleWare;
using System.Text.Json.Serialization;
using eCommerce.Core.Mappers;
using Microsoft.Extensions.Configuration;
using System.Data;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Add infrastrucure  Services;
builder.Services.AddInfrastruction();
builder.Services.AddCore();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

//string connectionstring = _configuration.GetConnectionString("PostgresConnection");
builder.Services.AddAutoMapper(typeof
    (ApplicationUserMappingProfile).Assembly);
// Build the WebApplication

builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();
//Routing
app.UseRouting();

//Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization(); 
//Controllers routes
app.MapControllers();
app.Run();
