using DotNetEnv;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

var secretKey = Environment.GetEnvironmentVariable("DOTNET_SECRET_KEY");
var enableLogging = Environment.GetEnvironmentVariable("DOTNET_ENABLE_LOGGING")?.ToLower() == "true";
var host = Environment.GetEnvironmentVariable("DOTNET_HOST") ?? "localhost";
var port = Environment.GetEnvironmentVariable("DOTNET_PORT") ?? "5000";

if (enableLogging)
{
    builder.Logging.AddConsole();
}

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run($"http://{host}:{port}");
