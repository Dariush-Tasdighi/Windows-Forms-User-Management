using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Seedwork;

public abstract class Entity : object
{
	public Entity() : base()
	{
		Id = Guid.NewGuid();
	}

	[Browsable(browsable: false)]
	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public Guid Id { get; protected set; }
}
