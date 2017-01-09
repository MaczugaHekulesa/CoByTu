using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using System.Diagnostics;

namespace CoByTu
{
    public partial class CategoryContentPage : ContentPage
    {
        IList<Meal> meals = new ObservableCollection<Meal>();

        static ListView listView;
        

        void displayData(IList<Meal> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                Debug.WriteLine(String.Join(" danie: ", i, " ", data[i]));
            }
        }

      
        public CategoryContentPage()
        {
           

            //BindingContext = meals;
            InitializeComponent();




            this.Content = new StackLayout { };


            Label bigLabel = new Label
            {
                FontSize = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            bigLabel.SetBinding(Label.TextProperty, "NameOfCategory");

            (this.Content as StackLayout).Children.Insert(0, bigLabel);

            
            listView = new ListView
            {

                RowHeight = 210,
                ItemsSource = meals,

                ItemTemplate = new DataTemplate(() =>
                {
                    Label mealName = new Label();
                    Label mealPrice = new Label();
                    Label mealKcal = new Label();
                    Label mealWeight = new Label();
                    Label mealPhoto = new Label();

                    mealName.SetBinding(Label.TextProperty, "MealName");
                    mealPrice.SetBinding(Label.TextProperty, "MealPrice");
                    mealKcal.SetBinding(Label.TextProperty, "MealKcal");
                    mealWeight.SetBinding(Label.TextProperty, "MealWeight");
                    mealPhoto.SetBinding(Label.TextProperty, "MealPhoto");

                    return new ViewCell
                    {
                        Height = 75,
                        View = new StackLayout
                        {
                            Padding = new Thickness(5, 5),
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            Orientation = StackOrientation.Vertical,
                            Children =
                            {
                                mealName,mealKcal,mealPrice,mealWeight,mealPhoto
                            }
                        }
                    };

                }



             )
            };


            (this.Content as StackLayout).Children.Insert(1, listView);


            Button newButton = new Button()
            {
                Text = "Pobierz dane"
            };
            newButton.Clicked += DownloadClicked;


            (this.Content as StackLayout).Children.Insert(2, newButton);


        }

        static async void DownloadClicked(object sender, EventArgs e)
        {
            DataManager manager = new DataManager();
            IList<Meal> list = await manager.GetAllMealsAsync();
            listView.ItemsSource = list;

        }


    }
}
