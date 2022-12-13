using ApiBackEnd.CultureApp.Business;
using ApiBackEnd.CultureApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiBackEnd.CultureApp.Api.Extensions
{
    public static class AppServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            //services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite("Data Source=..\\CultureApp.Data\\cultureapp.db");
                //.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddBusinessLayerServices();
            services.AddDataLayerServices();
            return services;
        }
    }
}