using MessageBoard.Business.Services;
using MessageBoard.Domain.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MessageBoard.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageService>();
            return services;
        }
        
    }
}
