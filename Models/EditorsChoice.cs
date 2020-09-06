using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagementSystem.Models
{
    public class EditorsChoice
    {
        [Key]
        public int ID { get; set; }

        public int Blog { get; set; }

    }
}
