using System;
using System.ComponentModel.DataAnnotations;
using Klevify.Data.Models;

namespace Klevify_Domain.Domain.Models
{
    public class Favorite
    {
        public int ID { get; set; }

        [Required]
        public int FKUserID { get; set; }

        [Required]
        public int FKBookID { get; set; }

        [Required]
        public int FKLanguageID { get; set; }

        [Required]
        public DateTime FavoritedAt { get; set; }

        public virtual User User { get; set; }
        public virtual BookLanguage BookLanguage { get; set; }
    }
}