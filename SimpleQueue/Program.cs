using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleQueue.Application.Services.Admin.Abstract;
using SimpleQueue.Application.Services.Admin.Concrete;
using SimpleQueue.Domain.Entities;
using SimpleQueue.Persistence.EFContext;

namespace SimpleQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.
                AddDbContext<EFIdentityCustomContext>(options => options.
                UseSqlServer(builder.Configuration.GetConnectionString("SQueueConnection")));

            builder.Services.AddTransient<IAccountService, AccountService>(); //DI
            builder.Services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 5; // минимальная длина пароля
                options.Password.RequireNonAlphanumeric = false;  // требуются ли не алфавитно-цифровые символы
                options.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                options.Password.RequireUppercase = false;// требуются ли символы в верхнем регистре
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
                options.Password.RequireDigit = false; // требуются ли цифры
                options.Lockout.MaxFailedAccessAttempts = 5; // попытка блока
            }).AddEntityFrameworkStores<EFIdentityCustomContext>().AddDefaultTokenProviders();


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}