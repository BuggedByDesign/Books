using System.ComponentModel.DataAnnotations;
using Klevify.Common;
using Klevify_Domain.Domain.Common;

namespace Klevify_Domain.Domain.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Required]
        [MaxLength(ValidationConstants.GenreNameMaxLength)]
        public string GenreName { get; set; }
    }
}