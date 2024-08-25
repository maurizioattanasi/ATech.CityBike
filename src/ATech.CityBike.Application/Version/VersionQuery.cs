
using MediatR;

namespace ATech.CityBike.Application.Version;

public record VersionQuery : IRequest<VersionResult>;
