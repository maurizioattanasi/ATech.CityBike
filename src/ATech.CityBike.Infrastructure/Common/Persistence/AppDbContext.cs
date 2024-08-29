using System.Reflection;

using ATech.CityBike.Domain.Trips;

using Microsoft.EntityFrameworkCore;

namespace ATech.CityBike.Infrastructure.Common.Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Trip> Trips { get; init; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder // Carica tutte le interfacce IEntityTypeConfiguration<TEntity>
            .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}