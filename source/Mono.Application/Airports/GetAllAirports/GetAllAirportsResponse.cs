namespace Mono.Application.Airports.GetAllAirports
{
    public class GetAllAirportsResponse
    {
        public GetAllAirportsResponse(IEnumerable<string> airports)
        {
            Airports = airports;
        }

        public IEnumerable<string> Airports { get; }
    }
}
