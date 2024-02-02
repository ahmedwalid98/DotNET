using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Models
{
    public class Blog
    {
        public int Id { get; set; }

        // [Required]
        public string? Url { get; set; }

        // to execlude class to migrate in db
        // [NotMapped]
        public List<Post>? Posts { get; set; }
    }
}
