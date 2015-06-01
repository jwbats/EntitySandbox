using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntitySandbox
{
	public class EntitiesContext : DbContext
	{
		public EntitiesContext() : base("EntitiesConnection")
		{
		}

		public DbSet<Person> Persons { get; set; }
	}
}