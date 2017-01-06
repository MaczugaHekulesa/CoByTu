using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class CategoryContentPage : ContentPage
    {
        public CategoryContentPage()
        {
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

                RowHeight = 120,
                ItemsSource = mealList,

                ItemTemplate = new DataTemplate(()  =>
                {
                    Label mealName = new Label();
                    Label mealPrice= new Label();
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
    }
}
