using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class AfterLogin : ContentPage
    {

        //buduje strone poniżej

        class Meal
        {
            public Meal(string name, int cost)
            {
                this.name = name;
                this.cost = cost;
            }
            public string name { private set; get; }
            public int cost { private set; get; }
        };



        public AfterLogin(bool head)
        {

            Func<string, string, Label> CreateLabel = (string source, string fmt) =>
            {
                Label label = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    HorizontalTextAlignment = TextAlignment.End
                };
                label.SetBinding(Label.TextProperty,
                    new Binding(source, BindingMode.OneWay, null, null, fmt));

                return label;
            };
            BackgroundColor = Color.FromHex("#d8434e");
            //Tu muszę zrobić podobną rzecz jak w "NamedColorPage" - Build the Page nno i chuj

            Label header = new Label
            {
                Text = "Dania",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            //jak tu nazwać jakoś tę listę, żebym mógł zaciągnąć Sourcea niżej w 75 wierszu jak nazwałem go"meals"
            this.Content = new List<Meal> //tu jak? :(
            {
                  {

                new Meal("Kaczka", 29),
                new Meal("Pierś z Kurczaka", 20),
                new Meal("Ciastko", 15),
                new Meal("Pierogi", 22),
                new Meal("Pizza", 12),
                new Meal("Zupa", 13),
                new Meal("Marmolada", 20),
                new Meal("Szparagi", 20),
                new Meal("Wołowina", 20),


            }
            };
        
            ListView listView = new ListView
            {
                ItemsSource = meals,
                ItemTemplate = new DataTemplate(() =>
               {
                   Label nameLabel = new Label();
                   nameLabel.SetBinding(Label.TextProperty, "name");

                   Label costLabel = new Label();
                   costLabel.SetBinding(Label.TextProperty,
                       new Binding("cost", BindingMode.OneWay,
                                   null, null, "Koszt to {0:d} zł"));
                   return new ViewCell
                   {
                       View = new StackLayout
                       {
                           Padding = new Thickness(0, 5),
                           Orientation = StackOrientation.Horizontal,
                           Children =
                            {

                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 5,
                                    Children =
                                    {
                                        nameLabel,
                                        costLabel
                                    }
                                }
                            }
                       }
                   };

               })

            };
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    listView
                }
            };
            if (head)
            {
                Label bigLabel = new Label
                {
                    FontSize = 50,
                    HorizontalOptions = LayoutOptions.Center
                };
                bigLabel.SetBinding(Label.TextProperty, "Name");
                (this.Content as StackLayout).Children.Insert(0, bigLabel);


            }

        }

    }
}


            
