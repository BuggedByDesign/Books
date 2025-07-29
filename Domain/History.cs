using System;
using System.ComponentModel.DataAnnotations;
using Klevify.Data.Models;

namespace Klevify_Domain.Domain.Models
{
    public class History
    {
        public int HistoryID { get; set; }

        [Required]
        public int FKUserID { get; set; }

        [Required]
        public int FKBookID { get; set; }

        [Required]
        public int FKLanguageID { get; set; }

        [Required]
        public int LastReadPosition { get; set; }

        public DateTime LastReadDate { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public bool IsFinished { get; set; }

        public virtual User User { get; set; }
        public virtual BookLanguage BookLanguage { get; set; }
    }
}