using Microsoft.EntityFrameworkCore;

namespace DotNet__1.Models
{
	public class TransactionDbContext:DbContext
	{
		 public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base (options)
		{

		}

		public DbSet<Transaction> Transactions { get; set; } 

	}
}
