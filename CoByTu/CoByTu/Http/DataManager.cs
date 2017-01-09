using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;
using System.IO;
using Org.Json;
namespace CoByTu
{
    class DataManager
    {
        

        private string TAG = "DataManager";
        
        HttpClient client;

       

        //private async Task<HttpClient> GetClient()
        //{
        //    HttpClient client = new HttpClient();
        //    if (string.IsNullOrEmpty(authorizationKey))
        //    {
        //        authorizationKey = await client.GetStringAsync(HttpConstans.Url);
        //        authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);

        //    }
        //    client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
        //    client.DefaultRequestHeaders.Add("Accept", "application/json");
        //    return client;
        //}

        public async Task<IList<Meal>> GetAllMealsAsync()
        {
            client = new HttpClient();

            string response = await client.GetStringAsync(HttpConstans.AllMealsURL);

            //Debug.WriteLine(String.Join(TAG, " response: ", response));

            IList<Meal> meals = parseResponseToJSONArray(response);
            //root = JsonConvert.DeserializeObject<Root>(response);

            return meals; // meals;
        }

        private IList<Meal> parseResponseToJSONArray(string response)
        {
            IList<Meal> list = new List<Meal>();

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
                    tempMealjsonObj.GetString("da_foto"));

                Debug.WriteLine(String.Join(TAG, "  TempMeaL: {", tempMeal.ToString(), "}"));
            
                list.Add(tempMeal);
            }
    
            return list;
        }
    }   
}
