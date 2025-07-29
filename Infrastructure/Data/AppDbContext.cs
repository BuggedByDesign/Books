
using Klevify.Data.Models;
using Klevify_Domain.Domain.Models;
using Microsoft.EntityFrameworkCore;


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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Book.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookLanguage>().HasKey(bl => new { bl.BookID, bl.LanguageID });
            modelBuilder.Entity<AuthorBook>().HasKey(ab => new { ab.BookID, ab.UserID });
        }
    }
}