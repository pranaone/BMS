﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class MembershipUserPermission
    {
        [Key]
        public int PermissionID { get; set; }

        public int MemberID { get; set; }

        public string Function { get; set; }

        public bool AllowInsert { get; set; }

        public bool AllowView { get; set; }
        
        public bool AllowEdit { get; set; }
        
        public bool AllowDelete { get; set; }

    }
}
