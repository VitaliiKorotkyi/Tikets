using Microsoft.EntityFrameworkCore;
using VKTiketsPG.Data;
using VKTiketsPG.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// ��������� ������� � ���������.
builder.Services.AddControllersWithViews();

// ������������� �������.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IProducersService,ProducersService>();

var app = builder.Build();

// ����������� �������� ��������� HTTP-��������.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // �������� HSTS �� ��������� ���������� 30 ����. ��������, �������� �������� ��� ��� ��������� ������������� � ��������, �������� https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//// ������������� ������� ��� ����������� Movies � �������� ��������� ��������.
//app.MapControllerRoute(
//    name: "actors",
//    pattern: "Actors/{action=Index}/{id?}",
//    defaults: new { controller = "Actors" });

//// ������������� ������� ��� ����������� Movies � �������� ��������� ��������.
//app.MapControllerRoute(
//    name: "movies",
//    pattern: "Movies",
//    defaults: new { controller = "Movies", action = "Index" });

// ������������� ������� �� ���������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
AppDbInitializer.Seed(app);
app.Run();
