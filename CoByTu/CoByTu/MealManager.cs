using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace CoByTu
{
    class MealManager
    {
        const string Url = "http://www.cobytu.com/cbt.php?d=j_przegladaj_dania5&uz=Darek&woj=wielkopolskie";
        private string authorizationKey;

        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(authorizationKey))
            {
                authorizationKey = await client.GetStringAsync(Url);
                authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);

            }
            client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }
        public async Task<IEnumerable<Meal>> GetAll()
        {
            HttpClient client = await GetClient();
            string result = await client.GetStringAsync(Url);
            var meals = JsonConvert.DeserializeObject<List<Meal>>(result);
            return JsonConvert.DeserializeObject<IEnumerable<Meal>>(result);
        }
    }   
}
