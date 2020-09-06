using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string Tag { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }
        
        [Required]
        public string Status { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public string Author { get; set; }

        public BlogCategory Category { get; set; }



    }
}
