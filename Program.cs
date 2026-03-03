using Microsoft.EntityFrameworkCore;
using MyWebApplication.Data;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();

// CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:8080")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Database
builder.Services.AddDbContext<SqlDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("kashmirTours")));

var app = builder.Build();

// Middleware Order Important
app.UseCors("AllowFrontend");

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // IMPORTANT

app.Run();