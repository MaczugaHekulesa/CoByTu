using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class CategoryContentPage : ContentPage
    {
        readonly IList<Meal> meals = new ObservableCollection<Meal>();
        readonly MealManager manager = new MealManager();




        public CategoryContentPage()
        {
            BindingContext = meals;
            InitializeComponent();


            this.Content = new StackLayout { };


            Label bigLabel = new Label
            {
                FontSize = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            bigLabel.SetBinding(Label.TextProperty, "NameOfCategory");

            (this.Content as StackLayout).Children.Insert(0, bigLabel);

            int i = 0;
            List<Meal> mealList = new List<Meal>{
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++),
                new Meal("Danie"+i++, "Cena"+i++, "kcal"+i++, "Waga"+i++,"Foto"+i++)


            };

            ListView listView = new ListView
            {

                RowHeight = 210,
                ItemsSource = mealList,

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
                    mealWeight.SetBinding(Label.TextProperty, "MealWight");
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


        }
        async void OnRefresh(object sender, EventArgs e)
        {
            // Turn on network indicator
            this.IsBusy = true;

            try
            {
                var mealCollection = await manager.GetAll();

                foreach (Meal meal in mealCollection)
                {
                    if (meals.All(b => b.MealName != meal.MealName))
                        meals.Add(meal);
                }
            }
            finally
            {
                this.IsBusy = false;
            }
        }
    }
}
