using System;
using System.ComponentModel.DataAnnotations;

namespace Klevify_Domain.Domain.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        public int FKGenreID { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        [Required]
        public int TotalPages { get; set; }

        [Required]
        public int EstimatedReadTimeInMinutes { get; set; }

        public virtual Genre Genre { get; set; }
    }
}