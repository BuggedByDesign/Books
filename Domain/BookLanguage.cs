using System.ComponentModel.DataAnnotations;
using Klevify_Domain.Domain.Common;
using Klevify_Domain.Domain.Models;

namespace Klevify.Data.Models
{
    public class BookLanguage
    {
        [Required]
        public int BookID { get; set; }

        [Required]
        public int LanguageID { get; set; }

        [Required]
        [MaxLength(ValidationConstants.BookNameMaxLength)]
        public string BookName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.BookDescriptionMaxLength)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public byte[] BookContent { get; set; }

        public bool IsReviewedByAdmin { get; set; }

        public virtual Book Book { get; set; }
        public virtual Language Language { get; set; }
    }
}