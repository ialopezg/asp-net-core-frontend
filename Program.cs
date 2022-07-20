using Frontend.Middlewares;
using Frontend.Themes;
using Frontend.Themes.Libraries;

var builder = WebApplication.CreateBuilder(args);

// Add theme and bootstrap services
builder.Services.AddScoped<ITheme, Theme>();
builder.Services.AddScoped<Theme>();
builder.Services.AddSingleton<IBootstrap, Bootstrap>();

// Add services to the container.
builder.Services.AddControllersWithViews();

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var app = builder.Build();

ThemeSettings.initialize(configuration);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseThemeMiddleware();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
