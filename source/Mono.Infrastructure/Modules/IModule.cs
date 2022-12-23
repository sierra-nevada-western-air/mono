using Microsoft.Extensions.DependencyInjection;

namespace Mono.Infrastructure.Modules
{
    public interface IModule
    {
        public void Register(IServiceCollection services);
    }
}
