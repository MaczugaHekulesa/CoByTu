using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class Rejestracja : ContentPage
    {
        public Rejestracja()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#d8434e");
            Content = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    header1,
                    login,
                    password,
                    repeatpassword,
                    email,
                    repeatemail,
                    register,
                }
            };
           
        }
        Label header1 = new Label()
        {
            Text = "REJESTRACJA",
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
        Entry repeatpassword = new Entry()
        {
            Placeholder = "Powtórz Hasło",
            BackgroundColor = Color.FromHex("#d8434e"),
            TextColor = Color.White,
            Opacity = 20,
            IsPassword = true,
        };
        Entry email = new Entry()
        {
            Placeholder = "E-mail",
            BackgroundColor = Color.FromHex("#d8434e"),
            TextColor = Color.White,
            Opacity = 20,
           
        };
        Entry repeatemail = new Entry()
        {
            Placeholder = "Powtórz E-mail",
            BackgroundColor = Color.FromHex("#d8434e"),
            TextColor = Color.White,
            Opacity = 20,

        };
        Button register = new Button()
        {
            Text = "Zarejestruj się",
            BackgroundColor = Color.Black,
            TextColor = Color.White,
        };
    }
}
