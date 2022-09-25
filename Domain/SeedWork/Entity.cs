namespace Domain.SeedWork
{
	public abstract class Entity : object
	{
		public Entity() : base()
		{
			//Id =
			//	new System.Guid();

			Id =
				System.Guid.NewGuid();
		}

		// **********
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		//public int Id { get; protected set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; protected set; }
		// **********
	}
}
