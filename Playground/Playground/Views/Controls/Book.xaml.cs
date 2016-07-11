using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Playground.Views.Controls
{
    public class BookCell : ViewCell
    {
        public BookCell()
        {
            var book = new Book();
            View = book;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = BindingContext as ViewModels.Controls.Book;
        }
    }

    public partial class Book : ContentView
    {
        public Book()
        {
            InitializeComponent();
        }
    }
}
