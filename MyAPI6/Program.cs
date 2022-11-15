using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using MyAPI6.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("SQLMovie");

var defaultLog = builder.Configuration["Logging:LogLevel:Default"];
var defaultLogAspNetCore = builder.Configuration["Logging:LogLevel:Microsoft.AspNetCore"];
var url = builder.Configuration["URLWeb"];
var AllowedHosts = builder.Configuration["AllowedHosts"];
var defaultLog2 = builder.Configuration["Logging:LogLevel"];


builder.Services.AddControllers();

// Add Nutget
//Microsoft.EntityFrameworkCore
//Microsoft.EntityFrameworkCore.SqlServer /oracel / mysql
//Microsoft.EntityFrameworkCore Tool de migration database

//add-migration innit

//update-database


builder.Services.AddDbContext<MovieContext>(options =>
             options.UseSqlServer(connectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
var version = typeof(Program).Assembly.GetName().Version.ToString();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = version,
        Title = "API",
        Description = "this is des",
        TermsOfService = new Uri("http://google.com"),
        Contact = new OpenApiContact
        {
            Name = "Contact 1",
            Url = new Uri("http://google.com")
        },
        License = new OpenApiLicense
        {
            Name = "Licenc",
            Url = new Uri("http://google.com")

        }

    });
});



builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", $"MY API NET 6.0 ver_{Assembly.GetExecutingAssembly().GetName().Version.ToString()}" );
       
    });
}






app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
