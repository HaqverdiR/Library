using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Context
{
    public class CategoryBook
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Category> Categoryes { get; set; }
    }
}