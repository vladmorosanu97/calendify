using Calendify.Application.Interfaces.Application;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Application.Users.Commands.RegisterUser;
using Calendify.Application.Users.Queries.ValidateUserEmail;
using Calendify.Application.Utils;
using Calendify.Persistence.Events;
using Calendify.Persistence.Shared;
using Calendify.Persistence.Users;
using Calendify.Utils;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Calendify.Ioc
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration);
            var configurationSection = configuration.GetSection("ConnectionStrings:DefaultConnection");
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configurationSection.Value));
            services.AddScoped<IDatabaseContext>(sp => sp.GetRequiredService<DatabaseContext>());

            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<ICommandHandler<RegisterUserCommand>, RegisterUserCommandHandler>();
            services.AddTransient<IQueryHandler<CheckDuplicateEmailQuery, Result>, CheckDuplicateEmailQueryHandler>();
            services.AddSingleton<Messages>();
            return services;
        }
    }
}
