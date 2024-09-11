using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TestShop.Data;
using TestShop.Data.intarfaces;
using TestShop.Data.mocks;
using TestShop.Data.Reposiroty;

namespace TestShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Добавление сервисов в контейнер
            builder.Services.AddScoped<IDoor, MockDoor>();
            builder.Services.AddScoped<IWindow, MockWindow>();//Потом создать репозиторий
            builder.Services.AddScoped<ICategory, MockCategory>();

            // Добавление конфигурации из файла dbsettings.json
            builder.Configuration.AddJsonFile("dbsettings.json", optional: true, reloadOnChange: true);

            // Настройка DbContext
            builder.Services.AddDbContext<AppDBContent>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services for controllers and views
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Настройка промежуточного ПО
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            // Map default controller route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Doors}/{action=List}/{id?}");

            app.Run();
        }
    }
}
