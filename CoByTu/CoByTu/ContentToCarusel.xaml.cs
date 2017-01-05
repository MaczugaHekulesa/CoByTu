using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class ContentToCarusel : ContentPage
    {
        public ContentToCarusel()
        {
            BackgroundColor = Color.Red;
            this.Title = "Posiłki";

            this.ItemsSource = new CaruselHeaders[]
            {
                new CaruselHeaders("Dania Główne"),
                new CaruselHeaders("Przystawki"),
                new CaruselHeaders("Desery")
            
            };

            this.ItemTemplate = new DataTemplate(() =>
            {
                return new AfterLogin(true);
            });
            InitializeComponent();
        }

        public CaruselHeaders[] ItemsSource { get; private set; }
        public DataTemplate ItemTemplate { get; private set; }
    }
}
