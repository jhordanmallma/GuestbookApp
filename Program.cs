using MiPrimeraAppWeb.Interfaces;
using MiPrimeraAppWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Registrar servicios
builder.Services.AddSingleton<IWelcomeService, WelcomeService>();
builder.Services.AddSingleton<IGuestbookService, GuestbookService>();

// 2. Registrar MVC (controllers + views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3. Middleware estático y logging (si lo tienes)
app.UseStaticFiles();
app.UseMiddleware<RequestLoggingMiddleware>();

// 4. Enrutamiento
app.UseRouting();

// 5. Mapear controladores MVC
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Guestbook}/{action=Create}/{id?}");
});

app.Run();
