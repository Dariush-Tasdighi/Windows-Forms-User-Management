namespace Data.Configurations
{
	internal class UserConfiguration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.User>
	{
		public UserConfiguration() : base()
		{
		}

		public void Configure(Microsoft.EntityFrameworkCore
			.Metadata.Builders.EntityTypeBuilder<Domain.User> builder)
		{
			// **************************************************
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
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			var user =
				new Domain.User(username: "Dariush", password: "1234512345")
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
}
