using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class MembershipGroup
    {
        [Key]
        public int GroupID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool AllowSignUp { get; set; }

        public bool NeedsApproval { get; set; }

    }
}
