using BPDiary_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace BPDiary_Final.Data
{
    public class DbContextDaily : DbContext
    {
		public DbContextDaily(DbContextOptions<DbContextDaily> options) : base(options)
		{

		}
		public DbSet<bp_diary_daily_aggregate> bp_diary_daily_aggregate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=postgres;Username=postgres;Password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bp_diary_daily_aggregate>().HasNoKey();  // Mark as a view, not a table
            modelBuilder.Entity<bp_diary_daily_aggregate>().ToView("bp_diary_daily_aggregate");  // Map to the SQL view
        }
    }
}
