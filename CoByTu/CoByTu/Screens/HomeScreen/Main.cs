using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            BackgroundImage = "presentation_bcg_1.jpg";

            Label welcome = new Label()
            {
                Text = "Oceniaj składniki i dodatki",
                FontSize = 15,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center

            };

            //Layout

            RelativeLayout relativeLayout = new RelativeLayout();

            relativeLayout.Children.Add(login,
                Constraint.Constant(-1),  // -1 żeby trochę była przerwa między przyciskami
                Constraint.RelativeToParent((parent) => {
                    return parent.Height - 58;  //normalnie powinno być -60 bo 60 to wysokość buttona, ale jest -2 żeby nie było luki od dołu ekranu (na Samsung Galaxy S7 Edge była luka)
                })

                /*Constraint.RelativeToParent((parent) => {
                    return parent.X * .5;
                }),
                Constraint.Constant(20)*/);

            relativeLayout.Children.Add(signup,
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .5;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height - 58;
                })/*,
                  Constraint.RelativeToParent((parent) => {
                      return parent.X * .5;
                  }),
                Constraint.Constant(20)*/);



            Image image = new Image
            {

                Source =
                    Device.OnPlatform(ImageSource.FromFile("logo_icon_android.png"),
                                      ImageSource.FromFile("logo_icon_android.png"),
                                      ImageSource.FromFile("logo_icon_android.png")),
                WidthRequest = 200,
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            Grid grid = new Grid
            {
                RowDefinitions = {
                    new RowDefinition { Height = 200},
                    new RowDefinition { Height = new GridLength (1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength (2, GridUnitType.Auto) }
                }
            };
            //grid.Children.Add(image, 0, 0);
            grid.Children.Add(image, 0, 1);
            grid.Children.Add(relativeLayout, 0, 2);

            Content = grid;

            //actions

            login.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new Logowanie());
            };
            signup.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new Rejestracja());
            };

        }

        Button login = new Button()
        {
            Text = "Logowanie",
            BorderColor = Color.FromHex("#d8434e"),
            BackgroundColor = Color.FromHex("#d8434e"),
            TextColor = Color.White,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            WidthRequest = 210,
            HeightRequest = 60
            // VerticalOptions = LayoutOptions.EndAndExpand,
        };



        Button signup = new Button()
        {

            Text = "Rejestracja",
            BackgroundColor = Color.FromHex("#d8434e"),
            BorderColor = Color.FromHex("#d8434e"),
            TextColor = Color.White,
            WidthRequest = 210,
            HeightRequest = 60
            //  VerticalOptions = LayoutOptions.EndAndExpand,

        };
    }
}