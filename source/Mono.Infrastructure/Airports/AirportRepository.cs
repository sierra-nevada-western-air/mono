using Mono.Application.Airports.Common;

namespace Mono.Infrastructure.Airports
{
    internal class AirportRepository : IAirportRepository
    {
        public Task<IEnumerable<string>> GetAllAirports()
        {
            return Task.FromResult(new List<string>
            {
                "Kansas City",
                "Memphis",
                "Pittsburgh",
                "Milwaukee",
            }.AsEnumerable());
        }
    }
}
