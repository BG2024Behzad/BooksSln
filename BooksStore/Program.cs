using Microsoft.EntityFrameworkCore;
using BookStore.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:BooksStoreConnection"]);
});
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
builder.Services.AddRazorPages();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapControllerRoute("Pagination", "Products/Page{productPage}", new { controller = "Home", action = "Index" });

app.MapDefaultControllerRoute();
app.MapRazorPages();
SeedData.EnsurePopulated(app);

app.Run();