using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Repository;
using DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Net.payOS;

namespace HomeHuntAPI.AppStarts
{
    public static class DependencyInjectionContainers
	{
		public static void InstallService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddRouting(options =>
			{
				options.LowercaseUrls = true; ;
				options.LowercaseQueryStrings = true;
			});
			services.AddDbContext<HomeHuntContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("Server"));
			});
            PayOS payOS = new PayOS(configuration["Environment:PAYOS_CLIENT_ID"] ?? throw new Exception("Cannot find environment"),
                    configuration["Environment:PAYOS_API_KEY"] ?? throw new Exception("Cannot find environment"),
                    configuration["Environment:PAYOS_CHECKSUM_KEY"] ?? throw new Exception("Cannot find environment"));

            services.AddSingleton(payOS);


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            //services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IAuthServices, AuthServices>();
			services.AddScoped<IUsersService, UsersServices>();
			services.AddScoped<IPostServices, PostServices>();
            services.AddScoped<ITransactionService, TransactionService>();
            //services.AddScoped<IContractService, ContractService>();
            //services.AddScoped<IFeedbackService, FeedbackService>();


        }
    }
}
