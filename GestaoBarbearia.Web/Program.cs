using GestaoBarbearia.Web.Data;
using GestaoBarbearia.Web.Repositorys;
using GestaoBarbearia.Web.Repositorys.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace GestaoBarbearia.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEntityFrameworkSqlServer()
                            .AddDbContext<GestaoBarbeariaContext>(
                                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                            );

            builder.Services.AddScoped<IAgendamentosRepositorys, AgendamentosRepositorys>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}