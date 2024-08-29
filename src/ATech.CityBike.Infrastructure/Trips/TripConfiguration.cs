using ATech.CityBike.Domain.Trips;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATech.CityBike.Infrastructure.Trips;

public class TripConfiguration : IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        builder.HasKey(f => f.Id);

        // builder.Property(f => f.Name).HasMaxLength(256);

        // builder.Property(f => f.UriOrPath).HasMaxLength(512);
        // builder
        //     .HasIndex(f => f.UriOrPath)
        //     .IsUnique();

        // builder.Property(f => f.Extension).HasMaxLength(10);

        // builder
        //     .HasIndex(f => f.CreationTimeUtc);

        // builder
        //     .HasMany(f => f.TrackGeometryDataRows)
        //     .WithOne(ls => ls.FileItem)
        //     .OnDelete(DeleteBehavior.Cascade);
    }
}