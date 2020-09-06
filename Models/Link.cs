using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class Link
    {
        [Key]
        public int ID { get; set; }
        
        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string WhatsApp { get; set; }

        public string Pinterest { get; set; }

        public string CommentsScript { get; set; }
        
        public string SharingScript { get; set; }

        public string JavaScript { get; set; }
    }
}
