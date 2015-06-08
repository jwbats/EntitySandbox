namespace EntitySandbox.GeneratedDataModels
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model2 : DbContext
	{
		public Model2()
			: base("name=Model2")
		{
		}

		public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
		public virtual DbSet<Person> Persons { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
