using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //1'e çok ilişki
        public List<Blog> Blogs { get; set; }
    }
}
