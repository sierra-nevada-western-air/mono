namespace Mono.Application.Airports.Common
{
    public interface IAirportRepository
    {
        Task<IEnumerable<string>> GetAllAirports();
    }
}
