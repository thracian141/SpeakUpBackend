using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpeakUp.Models;
using SpeakUp.Utilities;

namespace SpeakUp.Data {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,IdentityRole<int>,int> {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id=1,Name=ApplicationRoles.Admin,NormalizedName=ApplicationRoles.Admin.ToUpper() },
                new IdentityRole<int> { Id=2,Name=ApplicationRoles.Dev,NormalizedName=ApplicationRoles.Dev.ToUpper() },
                new IdentityRole<int> { Id=3,Name=ApplicationRoles.User,NormalizedName=ApplicationRoles.User.ToUpper() }
            );
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<DailyPerformance> DailyPerformances { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
    }
}
