using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoByTu
{
    class Meal
    {


        public string MealPrice { private set; get; }
        public string MealKcal { private set; get; }
        public string MealWight { private set; get; }
        public string MealPhoto { private set; get; }
        public string MealName { private set; get; }

        public Meal(string name, string price, string kcal, string weight, string photo)  //Klasa odpowiadajca za nazwe kategorii
        {
            this.MealName = name;
            this.MealKcal = kcal;
            this.MealPhoto = photo;
            this.MealPrice = price;
            this.MealWight = weight;

        }
        
        public override string ToString()
        {
            return MealName + " : " + MealKcal + " : " + MealPhoto + " : " + MealPrice + " : " + MealWight;


        }
    }
 }
