using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.Models2
{
    public class Book
    {
        // to make prop is primary key in data annotation way
        // [Key]
        public int BookKey { get; set; }
        public string Author { get; set; } = string.Empty;
        public string BookName { get; set; } = string.Empty;

        public int Rating { get; set; }

    }
}
