using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Models
{
    public class Book : Abstracts.Media
    {
        public Book() {}

        public Book(string author, string name, string description, Enums.Media mediaType) 
            : base(name, description, mediaType)
        {
            Author = author;
        }

        public string Author { get; set; }
    }
}
