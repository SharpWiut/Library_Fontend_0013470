﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryFrontend.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }

        // Navigation property
        public Author Author { get; set; }
    }
}