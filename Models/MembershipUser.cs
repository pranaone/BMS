using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class MembershipUser
    {
        [Key]
        public int MemberID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Location { get; set; }

        public DateTime SignUpDate { get; set; }

        public MembershipGroup GroupID { get; set; }

        public bool IsApproved { get; set; }

        public bool IsBanned { get; set; }

        public string Comments { get; set; }

        public string PassResetKey { get; set; }

        public int PassResetExpiry { get; set; }

    }
}
