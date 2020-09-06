using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class VisitorInfo
    {
        [Key]
        public int ID { get; set; }

        public string IPAddress { get; set; }

        public string UserAgent { get; set; }

        public DateTime TimeAccessed { get; set; }

    }
}
