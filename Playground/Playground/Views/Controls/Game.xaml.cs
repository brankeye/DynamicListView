using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Playground.Views.Controls
{
    public class GameCell : ViewCell
    {
        public GameCell()
        {
            var game = new Game();
            View = game;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var bindingContext = BindingContext as ViewModels.Controls.Game;
        }
    }

    public partial class Game : ContentView
    {
        public Game()
        {
            InitializeComponent();
        }
    }
}
