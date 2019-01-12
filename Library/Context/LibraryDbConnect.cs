﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Context
{
    public class LibraryDbConnect:DbContext
    {
        public LibraryDbConnect() : base("Dbconnect")
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categoryes { get; set; }
    }
}