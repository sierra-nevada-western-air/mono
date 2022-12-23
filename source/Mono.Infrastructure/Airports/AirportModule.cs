using Microsoft.Extensions.DependencyInjection;
using Mono.Application.Airports.Common;
using Mono.Infrastructure.Modules;

namespace Mono.Infrastructure.Airports
{
    internal class AirportModule : IModule
    {
        public void Register(IServiceCollection services)
        {
            services.AddTransient<IAirportRepository, AirportRepository>();
        }
    }
}
