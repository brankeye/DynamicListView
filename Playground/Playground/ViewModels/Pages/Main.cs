using System.Collections.Generic;

namespace Playground.ViewModels.Pages
{
    public class Main
    {
        public Main()
        {
            MediaList.Add(new ViewModels.Controls.Book());
            MediaList.Add(new ViewModels.Controls.Game());
            MediaList.Add(new ViewModels.Controls.Movie());
            MediaList.Add(new ViewModels.Controls.Book());
            MediaList.Add(new ViewModels.Controls.Game());
            MediaList.Add(new ViewModels.Controls.Movie());
            MediaList.Add(new ViewModels.Controls.Book());
            MediaList.Add(new ViewModels.Controls.Game());
            MediaList.Add(new ViewModels.Controls.Movie());
        }

        public List<Interfaces.IMedia> MediaList { get; set; }
            = new List<Interfaces.IMedia>(); 
    }
}
