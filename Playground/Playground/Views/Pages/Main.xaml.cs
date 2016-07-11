using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Playground.Views.Pages
{
    public partial class Main : ContentPage
    {
        private ViewModels.Pages.Main ViewModel => _viewModel ?? (_viewModel = BindingContext as ViewModels.Pages.Main);
        private ViewModels.Pages.Main _viewModel;

        public Main()
        {
            InitializeComponent();
            InitializePage();
        }

        private void InitializePage()
        {
            BindingContext = new ViewModels.Pages.Main();
        }
    }
}
