using Dapper;
using Dorixona.Application.Abstractions.Data;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.EmployeModel.Repository;
using Dorixona.Domain.Models.OrderModel.OrderRepository;
using Dorixona.Domain.Models.PillModel.PillRepository;
using Dorixona.Domain.Models.UserModel.UserRepository;
using Dorixona.Infrastructure.Data;
using Dorixona.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dorixona.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureRegisterServices(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            var connectionString =
               configuration.GetConnectionString("Database") ??
               throw new ArgumentNullException(nameof(configuration));

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPillRepository, PillRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IEmployeRepository, EmployeRepository>();


            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

            services.AddSingleton<ISqlConnection>(_ =>
                new SqlConnection(connectionString));

            SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());    

            return services;
        }
    }
}
