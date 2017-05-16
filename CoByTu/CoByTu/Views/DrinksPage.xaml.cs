using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu.Views
{
    public partial class DrinksPage : ContentPage
    {
        public DrinksPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Drink;
        }
    }
}
