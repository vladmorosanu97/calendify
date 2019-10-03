using Calendify.Application.Events.Commands;
using Calendify.Application.Interfaces.Application;
using Calendify.Application.Interfaces.Persistence;
using Calendify.Application.Users.Commands;
using Calendify.Persistence.Events;
using Calendify.Persistence.Shared;
using Calendify.Persistence.Users;
using Calendify.Utils;
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

            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IDatabaseContext, DatabaseContext>();

            services.AddTransient<ICommandHandler<RegisterUserCommand>>(provider =>
                new RegisterUserHandler(provider.GetService<UserRepository>()));
            return services;
        }
    }
}
