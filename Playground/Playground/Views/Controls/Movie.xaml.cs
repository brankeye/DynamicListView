using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Playground.Views.Controls
{
    public class MovieCell : ViewCell
    {
        public MovieCell()
        {
            var movie = new Movie();
            View = movie;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = BindingContext as ViewModels.Controls.Movie;
        }
    }

    public partial class Movie : ContentView
    {
        public Movie()
        {
            InitializeComponent();
        }
    }
}
