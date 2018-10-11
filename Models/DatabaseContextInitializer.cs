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
			Country country = null;

			for (int countryIndex = 1; countryIndex <= 200; countryIndex++)
			{
				country =
					new Country()
					{
						Code = countryIndex,
						Name = $"Country ({ countryIndex })",
					};

				databaseContext.Countries.Add(country);
			}

			// Optional
			databaseContext.SaveChanges();
		}
	}
}
