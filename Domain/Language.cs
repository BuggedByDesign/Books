using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Klevify.Data.Models;
using Klevify_Domain.Domain.Common;

namespace Klevify_Domain.Domain.Models
{
    public class Language
    {
        public int LanguageID { get; set; }

        [Required]
        [MaxLength(ValidationConstants.LanguageNameMaxLength)]
        public string LanguageName { get; set; }

        public virtual ICollection<BookLanguage> BookLanguages { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}