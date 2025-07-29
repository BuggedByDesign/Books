using System.ComponentModel.DataAnnotations;

namespace Klevify_Domain.Domain.Models
{
    public class ReadingGoal
    {
        public int GoalID { get; set; }

        [Required]
        public int FKUserID { get; set; }

        [Required]
        public int Year { get; set; }

        public int TargetBooks { get; set; }
        public int TargetPages { get; set; }
        public int CurrentBooks { get; set; }
        public int CurrentPages { get; set; }

        public virtual User User { get; set; }
    }
}