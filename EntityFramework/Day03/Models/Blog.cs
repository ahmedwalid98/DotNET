using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required, MaxLength(1000)]
        public string? Url { get; set; }
        public BlogImage? BlogImage { get; set; }
       /* public List<Post> Posts { get; set; }*/
    }
}
