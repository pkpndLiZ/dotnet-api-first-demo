using System;
namespace demoAPI.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> option) : base(option)
		{

		}

		public DbSet<Character> Characters => Set<Character>();
	}
}

