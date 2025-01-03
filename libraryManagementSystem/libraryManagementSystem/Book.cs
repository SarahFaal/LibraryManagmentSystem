﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public string DisplayInfo()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Author: {Author}, Available: {IsAvailable}";
        }
    }
}
