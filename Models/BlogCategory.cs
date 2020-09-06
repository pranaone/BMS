using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class BlogCategory
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
