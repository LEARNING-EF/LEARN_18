namespace Models
{
	internal class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
			for (int counter = 1; counter <= 200; counter++)
			{
				Country country =
					new Country
					{
						Code = counter,
						Name = $"Country ({ counter })",
					};

				databaseContext.Countries.Add(country);
			}

			// Optional
			databaseContext.SaveChanges();
		}
	}
}
