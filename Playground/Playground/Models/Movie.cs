using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Models
{
    public class Movie : Abstracts.Media
    {
        public Movie() {}

        public Movie(string director, string name, string description, Enums.Media mediaType) 
            : base(name, description, mediaType)
        {
            Director = director;
        }

        public string Director { get; set; }
    }
}
