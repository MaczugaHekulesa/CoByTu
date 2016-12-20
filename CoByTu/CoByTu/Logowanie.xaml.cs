using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class Logowanie : ContentPage
    {
        public Logowanie()
        {
            InitializeComponent();
            BackgroundColor = Color.Red;
            Content = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    header,
                    login,
                    password,
                    butlogin,
                    butface,
                }
            };

        }
        Label header = new Label()
        {
            Text = "LOGOWANIE",
            FontSize = 40,
            TextColor = Color.White,
        };
        Entry login = new Entry()
        {
            Placeholder = "Login",
            BackgroundColor = Color.Red,
            TextColor = Color.White,
            Opacity = 20,
            IsPassword = false,
        };
        Entry password = new Entry()
        {
            Placeholder = "Hasło",
            BackgroundColor = Color.Red,
            TextColor = Color.White,
            Opacity = 20,
            IsPassword = true,
        };
        Button butlogin = new Button()
        {
            Text = "Zaloguj się",
        };
        Button butface = new Button()
        {
            Text = "Zaloguj przez Facebooka",
            BackgroundColor = Color.Blue,
        };
    }
}
