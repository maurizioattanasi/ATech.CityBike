using ATech.CityBike.Application.Version;

using FastEndpoints;

using MediatR;

namespace ATech.CityBike.Api.Version;

public class VersionEndpoint(IMediator mediator) : Endpoint<EmptyRequest, VersionResponse, VersionResponseMapper>
{
    public override void Configure()
    {
        Get("api/Version");

        Options(opt=>opt.WithTags("Version"));

        AllowAnonymous(Http.GET);
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        var response = await mediator.Send(new VersionQuery());

        Response = Map.FromEntity(response);
    }
}
