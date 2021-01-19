using Microsoft.EntityFrameworkCore;
using System;
namespace MtSafe.Models
{
  public class MtSafeContext : DbContext
  {
    public MtSafeContext(DbContextOptions<MtSafeContext> options)
    : base(options)
    {
    }

    public DbSet<Report> Reports { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Report>()
      .HasData(
        new Report { ReportId = 1, Date = new DateTime(2021, 01, 19), Condition = "Icy", Location = "Mt. Hood", Username = "doublejep"},
        new Report { ReportId = 2, Date = new DateTime(2020, 09, 29), Condition = "Blizzard", Location = "Mt. Hood", Username = "RyGuy"},
        new Report { ReportId = 3, Date = new DateTime(2021, 01, 17), Condition = "Packed Powder", Location = "Crystal Mountain", Username = "2 Chains"},
        new Report { ReportId = 4, Date = new DateTime(2021, 01, 16), Condition = "High Avalanche Danger", Location = "Mt. Hood", Username = "Albert"},
        new Report { ReportId = 5, Date = new DateTime(2021, 01, 19), Condition = "Blue Bird", Location = "Mt. Bachelor", Username = "Peter"}
      );
    }
  }
}