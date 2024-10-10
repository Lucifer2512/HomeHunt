using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;

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

			services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IAuthServices, AuthServices>();
			services.AddScoped<IUsersService, UsersServices>();
			services.AddScoped<IHouseServices, HouseServices>();
			services.AddScoped<IPostServices, PostServices>();
			services.AddScoped<IRatingServices, RatingServices>();
			services.AddScoped<IRoomApplicationServices, RoomApplicationServices>();
			services.AddScoped<IRoomServices, RoomServices>();
			//services.AddScoped<IContractService, ContractService>();
			//services.AddScoped<IFeedbackService, FeedbackService>();


        }
    }
}
