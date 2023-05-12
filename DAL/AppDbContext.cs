using agileprojectsprint.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace agileprojectsprint.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingPlatform> MeetingPlatforms { get; set; }
    }
}
