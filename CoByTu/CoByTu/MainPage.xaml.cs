using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoByTu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            BackgroundImage = "logo_icon_android.png";

            Content = new StackLayout()
            {
                Children =

            {
            login,
            signup,
            }
            };
            login.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new Logowanie());
            };
            signup.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new Rejestracja());
            };

        }
        Label welcome = new Label()
        {
            Text = "Oceniaj składniki i dodatki",
            FontSize = 80,
            VerticalOptions = LayoutOptions.Start,
            TextColor = Color.Black,

        };
        Button login = new Button()
        {
            Text = "Logowanie",
            BorderColor = Color.Red,
            VerticalOptions = LayoutOptions.EndAndExpand,
        };
        Button signup = new Button()
        {
            Text = "Rejestracja",
            BorderColor = Color.Red,
            VerticalOptions = LayoutOptions.EndAndExpand,

        };
    }
}

