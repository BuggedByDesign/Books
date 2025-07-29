using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Klevify_Domain.Domain.Common;

namespace Klevify_Domain.Domain.Models
{
    public class MembershipType
    {
        public int MembershipTypeID { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MembershipTypeNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public int DurationInDays { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<UserMembership> UserMemberships { get; set; }
    }
}