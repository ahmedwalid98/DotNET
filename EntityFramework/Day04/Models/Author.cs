using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Models
{
#nullable disable
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

    }
}
