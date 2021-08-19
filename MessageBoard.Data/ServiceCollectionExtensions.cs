using MessageBoard.Data.Repositories;
using MessageBoard.Domain.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MessageBoard.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddData(this IServiceCollection services)
        {
            services.AddSingleton<IMessageRepository, MessageRepository>();
            return services;
        }
    }
}
