using AlgospringInsurance.App.Forms;
using AlgospringInsurance.DataAccess.Data;
using AlgospringInsurance.DataAccess.Repository;
using AlgospringInsurance.DataAccess.Repository.Contracts;
using AlgospringInsurance.DataAccess.UnitOfWork;
using AlgospringInsurance.Infrastructure;
using AlgospringInsurance.Services;
using AlgospringInsurance.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace AlgospringInsurance.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider? ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<AppDBContext>(options =>
                    {
                        var connectionString = ConfigurationManager.ConnectionStrings["algospringInsurance"].ConnectionString;
                        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                    });

                    services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
                    services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
                    services.AddTransient(typeof(IEmailReceiverRegistrationRepository), typeof(EmailReceiverRegistrationRepository));

                    services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));

                    services.AddTransient<LoginForm>();
                    services.AddTransient<UserForm>();
                    services.AddTransient<AdminForm>();

                    services.AddTransient<IValidationProvider, ValidationProvider>();
                    services.AddSingleton<IFormFactory, FormFactory>();
                });
        }
    }
}