using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Models
{
    #nullable disable
    public class Stock
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Industry { get; set; }
        public string Sympol { get; set; }
        public string Sector { get; set; }

        public string Balance { get; set; }
    }
}
