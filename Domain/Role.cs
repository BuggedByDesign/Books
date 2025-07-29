using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Klevify_Domain.Domain.Common;

namespace Klevify_Domain.Domain.Models
{
    public class Role
    {
        public int RoleID { get; set; }

        [Required]
        [MaxLength(ValidationConstants.RoleNameMaxLength)]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}