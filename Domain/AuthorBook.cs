using System.ComponentModel.DataAnnotations;

namespace Klevify_Domain.Domain.Models
{
    public class AuthorBook
    {
        [Required]
        public int BookID { get; set; }

        [Required]
        public int UserID { get; set; }

        public bool IsMainAuthor { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}