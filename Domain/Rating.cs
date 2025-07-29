using System;
using System.ComponentModel.DataAnnotations;

namespace Klevify_Domain.Domain.Models
{
    public class Rating
    {
        public int RatingID { get; set; }

        [Required]
        public int FKUserID { get; set; }

        [Required]
        public int FKBookID { get; set; }

        [Required]
        public int FKLanguageID { get; set; }

        [Required]
        [Range(1, 5)]
        public int Score { get; set; }

        public string Comment { get; set; }

        [Required]
        public DateTime RatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public virtual Language Language { get; set; }
    }
}