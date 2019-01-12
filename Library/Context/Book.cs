using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Context
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Date { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public virtual Author Autors { get; set; }
        
    }
}