using System.ComponentModel.DataAnnotations;
using Klevify_Domain.Domain.Common;

namespace Klevify_Domain.Domain.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(ValidationConstants.UserNameMaxLength)]
        public string UserName { get; set; }

        [Required]
        [MinLength(ValidationConstants.PasswordMinLength)]
        [MaxLength(ValidationConstants.PasswordMaxLength)]
        public string Password { get; set; }

        [Required]
        [MaxLength(ValidationConstants.FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.LastNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int FK_Role { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<UserMembership> UserMemberships { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<ReadingGoal> ReadingGoals { get; set; }
    }
}