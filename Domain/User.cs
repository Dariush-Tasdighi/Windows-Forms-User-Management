using Domain.Seedwork;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class User(string username, string password) : Entity
{
	//[Display(Name = "Admin")]
	[DisplayName(displayName: "Admin")]
	public bool IsAdmin { get; set; }

	[DisplayName(displayName: "Active")]
	public bool IsActive { get; set; }

	[Required(AllowEmptyStrings = false)]
	[StringLength(maximumLength: 20, MinimumLength = 6)]
	public string Username { get; set; } = username;

	[Browsable(browsable: false)]
	[Required(AllowEmptyStrings = false)]
	[StringLength(maximumLength: 20, MinimumLength = 8)]
	public string Password { get; set; } = password;

	[MaxLength(length: 50)]
	[DisplayName(displayName: "Full Name")]
	public string? FullName { get; set; }

	[Browsable(browsable: false)]
	public string? Description { get; set; }
}
