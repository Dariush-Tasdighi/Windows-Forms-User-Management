namespace Domain
{
	public class User : SeedWork.Entity
	{
		//public User() : base()
		//{
		//}

		public User(string username, string password) : base()
		{
			Username = username;
			Password = password;
		}

		// **********
		public bool IsAdmin { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.MaxLength
		//	(length: 20)]

		//[System.ComponentModel.DataAnnotations.MinLength
		//	(length: 6)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6)]

		[System.ComponentModel.DataAnnotations.Required]
		public string Username { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.MaxLength
		//	(length: 40)]

		//[System.ComponentModel.DataAnnotations.MinLength
		//	(length: 8)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 8)]

		[System.ComponentModel.DataAnnotations.Required]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 50)]
		public string? FullName { get; set; }
		// **********

		// **********
		public string? Description { get; set; }
		// **********
	}
}
