namespace ns;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    // public DbSet<FileItem> Files { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder // Carica tutte le interfacce IEntityTypeConfiguration<TEntity>
            .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}