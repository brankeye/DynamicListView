using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Enums;

namespace Playground.Abstracts
{
    public abstract class Media : Interfaces.IMedia
    {
        public Media() {}

        public Media(string name, string description, Enums.Media mediaType)
        {
            Name = name;
            Description = description;
            MediaType = mediaType;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public Enums.Media MediaType { get; set; }
    }
}
