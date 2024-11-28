using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class ApplicationDbContext : DbContext
{
#pragma warning disable CS8618
	public ApplicationDbContext() : base()
#pragma warning restore CS8618
	{
		Database.EnsureCreated();
	}

	public DbSet<User> Users { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=USER_MANAGEMENT;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder
			.UseSqlServer(connectionString: connectionString)
			;
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly
			(assembly: typeof(ApplicationDbContext).Assembly);

		//modelBuilder.ApplyConfigurationsFromAssembly
		//	(assembly: typeof(Configurations.UserConfiguration).Assembly);
	}
}
