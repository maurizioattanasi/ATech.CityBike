using ATech.CityBike.Application.Version;

using FastEndpoints;

namespace ATech.CityBike.Api.Version;

public class VersionResponseMapper : Mapper<EmptyRequest, VersionResponse, VersionResult>
{
    public override VersionResponse FromEntity(VersionResult e) => new VersionResponse(e.Version);
}