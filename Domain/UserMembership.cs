using System;
using System.ComponentModel.DataAnnotations;

namespace Klevify_Domain.Domain.Models
{
    public class UserMembership
    {
        public int ID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int MembershipTypeID { get; set; }

        [Required]
        public DateTime LastPaymentDate { get; set; }

        [Required]
        public DateTime EndOfBillingPeriod { get; set; }

        public bool IsActive { get; set; }

        public virtual User User { get; set; }
        public virtual MembershipType MembershipType { get; set; }
    }
}