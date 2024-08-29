using ATech.CityBike.Application.Trips;
using ATech.CityBike.Domain.Trips;
using ATech.CityBike.Infrastructure.Common.Persistence;
using ATech.Repository.EntityFrameworkCore;

namespace ATech.CityBike.Infrastructure.Trips;

public class TripRepository(AppDbContext context)
    : Repository<Trip, string>(context), ITripRepository
{ }