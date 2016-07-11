using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.ViewModels.Controls
{
    public class Movie : Interfaces.IMedia
    {
        public Movie()
        {
            MovieModel = new Models.Movie
            {
                Director = "Quentin Tarantino",
                Name = "Django",
                Description = "Western movie",
                MediaType = Enums.Media.MOVIE
            };
            MediaType = MovieModel.MediaType;
        }

        public Models.Movie MovieModel { get; set; }

        public Enums.Media MediaType { get; set; }
    }
}
