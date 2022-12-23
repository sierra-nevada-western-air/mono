using System.ComponentModel.DataAnnotations;

namespace Mono.Application.Airports.GetAllAirports
{
    public class GetAllAirportsResponse
    {
        public GetAllAirportsResponse(IEnumerable<string> airports)
        {
            Airports = airports;
        }

        [Required]
        public IEnumerable<string> Airports { get; }
    }
}
