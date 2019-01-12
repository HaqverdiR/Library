using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Context
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}