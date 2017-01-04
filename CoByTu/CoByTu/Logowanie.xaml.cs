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
            BackgroundColor = Color.FromHex("#d8434e");
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
            butlogin.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new AfterLogin());
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
            BackgroundColor = Color.FromHex("#d8434e"),
            TextColor = Color.White,
            Opacity = 20,
            IsPassword = false,
        };
        Entry password = new Entry()
        {
            Placeholder = "Hasło",
            BackgroundColor = Color.FromHex("#d8434e"),
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
            BackgroundColor = Color.FromHex("#4c69ba")
        };
    }
}
