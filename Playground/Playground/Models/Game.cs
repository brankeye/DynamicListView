using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Models
{
    public class Game : Abstracts.Media
    {
        public Game() {}

        public Game(string developer, string name, string description, Enums.Media mediaType) 
            : base(name, description, mediaType)
        {
            Developer = developer;
        }

        public string Developer { get; set; }
    }
}
