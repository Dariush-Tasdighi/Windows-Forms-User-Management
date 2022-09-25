using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
#pragma warning disable CS8618
		public DatabaseContext() : base()
#pragma warning restore CS8618
		{
			// **************************************************
			Database.EnsureCreated();
			// **************************************************
		}

		public Microsoft.EntityFrameworkCore.DbSet<Domain.User> Users { get; set; }

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString =
				"Server=.;Database=USER_MANAGEMENT;MultipleActiveResultSets=true;User ID=sa;Password=1234512345;";

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
}
