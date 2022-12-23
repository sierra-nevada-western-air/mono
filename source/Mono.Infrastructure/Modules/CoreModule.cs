using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Mono.Infrastructure.Airports;

namespace Mono.Infrastructure.Modules
{
    public class CoreModule : IModule
    {
        public void Register(IServiceCollection services)
        {
            services.AddMediatR(Assembly.Load("Mono.Application"));

            new List<IModule>
            {
                new AirportModule(),
            }.ForEach(module => module.Register(services));
        }
    }
}
