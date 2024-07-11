using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Seedwork;

public abstract class Entity : object
{
	[Browsable(browsable: false)]
	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public Guid Id { get; protected set; } = Guid.NewGuid();
}
