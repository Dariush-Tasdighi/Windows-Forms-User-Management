using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class UserConfiguration : object, IEntityTypeConfiguration<User>
{
	public UserConfiguration() : base()
	{
	}

	public void Configure(EntityTypeBuilder<User> builder)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.HasKey(current => current.Id)
			.IsClustered(clustered: false)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current => current.Username)
			.IsUnicode(unicode: false)
			;

		builder
			.HasIndex(current => new { current.Username })
			.IsUnique(unique: true)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current => current.Password)
			.IsUnicode(unicode: false)
			;
		// **************************************************

		// **************************************************
		builder
			.HasIndex(current => new { current.FullName })
			.IsUnique(unique: false)
			;
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// *** Seed Data ************************************
		// **************************************************
		var user =
			new User(username: "Dariush", password: "1234512345")
			{
				IsAdmin = true,
				IsActive = true,
				Description = null,
				FullName = "Mr. Dariush Tasdighi",
			};

		builder.HasData(data: user);
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
