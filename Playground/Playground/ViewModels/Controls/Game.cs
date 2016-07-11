using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.ViewModels.Controls
{
    public class Game : Interfaces.IMedia
    {
        public Game()
        {
            GameModel = new Models.Game
            {
                Developer = "Naughty Dog",
                Name = "The Last of Us",
                Description = "Post-apocalyptic game",
                MediaType = Enums.Media.GAME
            };
            MediaType = GameModel.MediaType;
        }

        public Models.Game GameModel { get; set; }

        public Enums.Media MediaType { get; set; }
    }
}
