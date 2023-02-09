using Microsoft.EntityFrameworkCore;
using NiceLia.Models.Domain;

namespace NiceLia.Data
{
	public class UserDbContext : DbContext
	{
		public UserDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> _users{ get; set; }
	}
}
