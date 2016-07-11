using Xamarin.Forms;

namespace Playground.Selectors
{
    public class Media : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var media = (Interfaces.IMedia)item;
            DataTemplate template;

            switch(media.MediaType)
            {
                case Enums.Media.BOOK:
                    template = BookTemplate;
                    break;
                case Enums.Media.GAME:
                    template = GameTemplate;
                    break;
                case Enums.Media.MOVIE:
                    template = MovieTemplate;
                    break;
                default:
                    template = BookTemplate;
                    break;
            }

            return template;
        }

        public DataTemplate BookTemplate { get; set; }

        public DataTemplate GameTemplate { get; set; }

        public DataTemplate MovieTemplate { get; set; }
    }
}
