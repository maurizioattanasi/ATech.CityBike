using ATech.CityBike.Domain.Trips;
using ATech.Repository;

namespace ATech.CityBike.Application.Trips;

public interface ITripRepository : IRepository<Trip, string>
{
}