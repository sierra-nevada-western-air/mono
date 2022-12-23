namespace Mono.Application.Airports.GetAllAirports
{
    using MediatR;
    using Common;

    public class GetAllAirportsHandler : IRequestHandler<GetAllAirportsRequest, GetAllAirportsResponse>
    {
        private readonly IAirportRepository _airportRepository;

        public GetAllAirportsHandler(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public async Task<GetAllAirportsResponse> Handle(GetAllAirportsRequest request, CancellationToken cancellationToken)
        {
            var airports = await _airportRepository.GetAllAirports();

            return new GetAllAirportsResponse(airports);
        }
    }
}
