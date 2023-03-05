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
using Serilog.Sinks.MSSqlServer;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using BankSystem.Mvc.CustomLogging;
using Serilog.Context;

namespace BankSystem.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigurationManager Configuration = builder.Configuration;



            //LOGGING 
            SqlColumn sqlColumn = new SqlColumn();
            sqlColumn.ColumnName = "UserName";
            sqlColumn.DataType = System.Data.SqlDbType.NVarChar;
            sqlColumn.PropertyName= "UserName";
            sqlColumn.DataLength = 50;
            sqlColumn.AllowNull= true;

            ColumnOptions columnOpt = new ColumnOptions();
            columnOpt.Store.Remove(StandardColumn.Properties);
            columnOpt.Store.Add(StandardColumn.LogEvent);
            columnOpt.AdditionalColumns = new Collection<SqlColumn> { sqlColumn };

            Logger log = new LoggerConfiguration()
               .WriteTo.Console()
               .WriteTo.File("logs/log.txt")
               .WriteTo.MSSqlServer(connectionString: builder.Configuration.GetConnectionString("SqlServer"),
               sinkOptions: new MSSqlServerSinkOptions
               {
                   AutoCreateSqlTable = true,
                   TableName = "logs"
               },
               appConfiguration: null,
               columnOptions: columnOpt)
               .WriteTo.Seq(builder.Configuration["Seq:ServerURL"])
               .Enrich.FromLogContext()
               .Enrich.With<CustomUserNameColumn>()
               .MinimumLevel.Information()
               .CreateLogger();
              


            // Add services to the container.
            builder.Services.AddDbContext<BankSystemContext>(opts =>
            {
                opts.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
            });


            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BankSystemContext>();
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICartService, CartManager>();
            builder.Services.AddScoped<ICartApplicationService, CartApplicationManager>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Host.UseSerilog(log);

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

            app.Use(async (context, next) =>
            {
                var username = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identity.Name : null;
                LogContext.PushProperty("UserName", username);
                await next();
            });

            app.MapRazorPages();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}