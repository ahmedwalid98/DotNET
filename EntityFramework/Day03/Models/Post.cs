using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int BlogId { get; set; }
        /*public Blog Blog { get; set; }*/

        /*public ICollection<Tag> Tags { get; set; }*/
        public List<PostTag> PostTags { get; set; }
    }
}
