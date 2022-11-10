namespace Domain;

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
	[System.ComponentModel.DisplayName
		(displayName: "Admin")]
	public bool IsAdmin { get; set; }
	// **********

	// **********
	[System.ComponentModel.DisplayName
		(displayName: "Active")]
	public bool IsActive { get; set; }
	// **********

	// **********
	//[System.ComponentModel.DataAnnotations.MaxLength
	//	(length: 20)]

	//[System.ComponentModel.DataAnnotations.MinLength
	//	(length: 6)]

	[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 20, MinimumLength = 6)]

	//[System.ComponentModel.DataAnnotations.Required]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
	public string Username { get; set; }
	// **********

	// **********
	//[System.ComponentModel.DataAnnotations.MaxLength
	//	(length: 40)]

	//[System.ComponentModel.DataAnnotations.MinLength
	//	(length: 8)]

	[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 20, MinimumLength = 8)]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

	[System.ComponentModel.Browsable(browsable: false)]
	public string Password { get; set; }
	// **********

	// **********
	[System.ComponentModel.DisplayName
		(displayName: "Full Name")]

	[System.ComponentModel.DataAnnotations.Display
		(Name = "Full Name")]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: 50)]
	public string? FullName { get; set; }
	// **********

	// **********
	[System.ComponentModel.Browsable(browsable: false)]
	public string? Description { get; set; }
	// **********
}
