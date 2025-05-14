var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Hoặc đăng ký với tên
builder.Services.AddHttpClient("ShoppingAPIClient", client =>
{
    //client.BaseAddress = new Uri("http://localhost:5000"); // Môi trường localhost của API
    
    var configuration = builder.Configuration;
    var shoppingApiUrl = configuration["ShoppingAPIUrl"];
    client.BaseAddress = new Uri(shoppingApiUrl ?? "");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
