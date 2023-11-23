namespace Domain.Seedwork;

public abstract class Entity : object
{
	public Entity() : base()
	{
		Id = System
			.Guid.NewGuid();

		// دستور ذیل غلط می‌باشد
		//Id = new System.Guid();
	}

	// **********
	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//public int Id { get; protected set; }
	// **********

	// **********
	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//public System.Guid Id { get; protected set; }
	// **********

	// **********
	[System.ComponentModel.Browsable
		(browsable: false)]

	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	public System.Guid Id { get; protected set; }
	// **********
}
