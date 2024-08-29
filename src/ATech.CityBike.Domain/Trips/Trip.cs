using System;

namespace ATech.CityBike.Domain.Trips;

public class Trip
{
    public string Id { get; set; } = null!;

    public ushort BikeId { get; set; }

    public ushort BirthYear { get; set; }

    public ushort EndStationId { get; set; }
}
