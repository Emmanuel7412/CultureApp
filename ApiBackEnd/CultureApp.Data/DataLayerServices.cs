using ApiBackEnd.CultureApp.Data.Repositories;
using ApiBackEnd.CultureApp.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBackEnd.CultureApp.Data
{
    public static class DataLayerServices
    {
        public static void AddDataLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IDPUsers, DPUsers>();
        }
    }
}