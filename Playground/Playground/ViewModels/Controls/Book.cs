using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Enums;

namespace Playground.ViewModels.Controls
{
    public class Book : Interfaces.IMedia
    {
        public Book()
        {
            BookModel = new Models.Book
            {
                Author = "Glen Cook",
                Name = "The Black Company",
                Description = "Fantasy novel",
                MediaType = Enums.Media.BOOK
            };
            MediaType = BookModel.MediaType;
        }

        public Models.Book BookModel { get; set; }

        public Enums.Media MediaType { get; set; }
    }
}
