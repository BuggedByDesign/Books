
using Klevify.Data.Models;
using Klevify_Domain.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Klevify.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLanguage> BookLanguages { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ReadingGoal> ReadingGoals { get; set; }
        public DbSet<UserMembership> UserMemberships { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MembershipType>()
                .Property(m => m.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<BookLanguage>()
                .HasKey(bl => new { bl.BookID, bl.LanguageID });

            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.BookID, ab.UserID });
        }

    }
}