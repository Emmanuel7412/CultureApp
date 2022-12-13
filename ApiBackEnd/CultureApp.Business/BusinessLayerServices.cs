using ApiBackEnd.CultureApp.Business.DMAccount.Business;
using ApiBackEnd.CultureApp.Business.DMAccount.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBackEnd.CultureApp.Business
{
    public static class BusinessLayerServices
    {
        public static void AddBusinessLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IBSAccount, BSAccount>();
        }
    }
}