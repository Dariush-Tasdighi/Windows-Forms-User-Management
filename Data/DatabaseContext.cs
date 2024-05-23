using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DatabaseContext : DbContext
{
	public DatabaseContext() : base()
	{
		Database.EnsureCreated();
	}

	public DbSet<Domain.User> Users { get; set; }

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=USER_MANAGEMENT;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		// UseSqlServer() -> using Microsoft.EntityFrameworkCore;
		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly
			(assembly: typeof(Configurations.UserConfiguration).Assembly);
	}
}
