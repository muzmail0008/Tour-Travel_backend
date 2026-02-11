using Microsoft.EntityFrameworkCore;
using MyWebApplication.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddAuthentication(); 

// Add services to the container.
// builder.Services.AddSingleton<ITokenService , TokenService>();
// builder.Services.AddSingleton<IClouldinaryService,CloudinaryService>();
builder.Services.AddControllersWithViews();
// builder.Services.AddScoped<IMailService, EmailService>();
builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("kashmirTours")));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
  
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseExceptionHandler("/Error");
app.UseStaticFiles();

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();   // use static files present in wwwwroot 
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


 
