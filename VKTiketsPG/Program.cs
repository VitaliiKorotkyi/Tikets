using Microsoft.EntityFrameworkCore;
using VKTiketsPG.Data;
using VKTiketsPG.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер.
builder.Services.AddControllersWithViews();

// Конфигурируем сервисы.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IProducersService,ProducersService>();

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Значение HSTS по умолчанию составляет 30 дней. Возможно, захотите изменить это для сценариев использования в продакшн, смотрите https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//// Устанавливаем маршрут для контроллера Movies в качестве стартовой страницы.
//app.MapControllerRoute(
//    name: "actors",
//    pattern: "Actors/{action=Index}/{id?}",
//    defaults: new { controller = "Actors" });

//// Устанавливаем маршрут для контроллера Movies в качестве стартовой страницы.
//app.MapControllerRoute(
//    name: "movies",
//    pattern: "Movies",
//    defaults: new { controller = "Movies", action = "Index" });

// Устанавливаем маршрут по умолчанию
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
AppDbInitializer.Seed(app);
app.Run();
