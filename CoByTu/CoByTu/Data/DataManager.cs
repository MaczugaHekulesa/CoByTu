using Org.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoByTu.Data.Models;

namespace CoByTu.Data
{
    public class DataManager
    {
        #region Const
        public const string AllMealsURL = "http://www.cobytu.com/cbt.php?d=j_przegladaj_dania5&uz=Darek";
        public const string PhotoPath = "http://cobytu.com/foto/";
        #endregion

        HttpClient client = new HttpClient();
        List<Meal> response = new List<Meal>();

        public async Task<List<Meal>> GetAllMealsFromApiAsync()
        {
            client = new HttpClient();

            string response = await client.GetStringAsync(AllMealsURL);

            List<Meal> meals = GetAllMeals(response);

            return meals;
        }

        public List<Meal> GetAllMeals(string response)
        {
            List<Meal> list = new List<Meal>();

            JSONObject jsonObjectRoot = new JSONObject(response);

            JSONArray jsonArrayDania = jsonObjectRoot.GetJSONArray("dania");

            for (int i = 0; i < jsonArrayDania.Length(); i++)
            {
                JSONObject tempMealjsonObj = jsonArrayDania.GetJSONObject(i);
                Meal tempMeal = new Meal(
                    tempMealjsonObj.GetString("da_nazwa"),
                    tempMealjsonObj.GetString("kcal"),
                    tempMealjsonObj.GetString("cena"),
                    tempMealjsonObj.GetString("waga"),
                    PhotoPath + tempMealjsonObj.GetString("da_foto"),
                    tempMealjsonObj.GetString("da_kategoria"));

                list.Add(tempMeal);
            }

            return list;
        }

        public async Task<List<Meal>> GetMealsFromCategoryAsync(string category)
        {
            List<Meal> chosenCategoryMeal = new List<Meal>();
            List<Meal> meals = await GetAllMealsFromApiAsync();

            chosenCategoryMeal = meals.Where(m => m.MealCategory.Contains(category)).ToList();

            return chosenCategoryMeal;
        }
    }
}
