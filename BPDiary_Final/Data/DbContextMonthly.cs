using BPDiary_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace BPDiary_Final.Data
{
	public class DbContextMonthly : DbContext
	{
		public DbContextMonthly(DbContextOptions<DbContextMonthly> options) : base(options)
		{

		}
		public DbSet<bp_diary_monthly_aggregate> bp_diary_monthly_aggregate { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=postgres;Username=postgres;Password=password");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<bp_diary_monthly_aggregate>().HasNoKey();  // Mark as a view, not a table
			modelBuilder.Entity<bp_diary_monthly_aggregate>().ToView("bp_diary_monthly_aggregate");  // Map to the SQL view
		}
	}
}
