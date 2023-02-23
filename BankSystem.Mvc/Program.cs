using BankSystem.Data.EntityFramework.Contexts;
using BankSystem.Data.EntityFramework.Repositories.Abstract;
using BankSystem.Data.EntityFramework.Repositories.Concrete;
using BankSystem.Data.UnitOfWorks.Abstract;
using BankSystem.Data.UnitOfWorks.Concrete;
using BankSystem.Entities.Entities;
using BankSystem.Service.Concrete;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BankSystem.Service.Abstract;

namespace BankSystem.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigurationManager Configuration = builder.Configuration;



            // Add services to the container.
            builder.Services.AddDbContext<BankSystemContext>(opts =>
            {
                opts.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
            });


            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BankSystemContext>();
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICartService, CartManager>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}