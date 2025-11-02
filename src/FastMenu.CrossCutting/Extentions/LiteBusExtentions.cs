using FastMenu.Application.Handlers.Commands;
using FastMenu.Application.Handlers.Queries;
using LiteBus.Commands.Extensions.MicrosoftDependencyInjection;
using LiteBus.Queries.Extensions.MicrosoftDependencyInjection;
using LiteBus.Messaging.Extensions.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace FastMenu.CrossCutting.Extentions
{
    public static class LiteBusExtentions
    {
        public static IServiceCollection ConfigureLiteBus(this IServiceCollection services)
        {
            services.AddLiteBus(litebus =>
            {
                litebus.AddCommandModule(module =>
                {
                    module.RegisterFromAssembly(typeof(AddFoodCommandHandler).Assembly);
                });

               litebus.AddQueryModule(module =>
               {
                   module.RegisterFromAssembly(typeof(GetFoodQueryHandler).Assembly);
               });
            });

            return services;
        }
    }
}