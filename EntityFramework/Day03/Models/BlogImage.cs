using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03.Models
{
    public class BlogImage
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Caption { get; set; }
        public int BlogForeignKey { get; set; }
        /*[ForeignKey("BlogForeignKey")]*/
        public Blog Blog { get; set; }
    }
}
