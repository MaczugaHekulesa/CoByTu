using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CoByTu
{
    public class CategoryCarouselPage : CarouselPage
    {
        public CategoryCarouselPage()
        {
            this.Title = "Posiłki";

            this.ItemsSource = new CategoryName[]
            {
                new CategoryName("Dania Główne"),
                new CategoryName("Przystawki"),
                new CategoryName("Desery")

            };

            this.ItemTemplate = new DataTemplate(() =>
            {
                return new CategoryContentPage();
            });


        }
    }
}
