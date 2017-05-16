using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoByTu.Data.Models
{
    public class Meal
    {

        [JsonProperty("da_id")]
        public string MealId { private set; get; }

        [JsonProperty("da_uz_id")]
        public string UserId { private set; get; }

        [JsonProperty("da_foto")]
        public string MealPhoto { private set; get; }

        [JsonProperty("da_gdzie")]
        public string Restaurant { private set; get; }

        [JsonProperty("da_kategoria")]
        public string MealCategory { private set; get; }

        [JsonProperty("da_podkategoria")]
        public List<string> Subcategory { private set; get; }

        [JsonProperty("da_rodzaj")]
        public string MealType { private set; get; }

        [JsonProperty("da_nazwa")]
        public string MealName { private set; get; }

        [JsonProperty("da_opis")]
        public string MealDescription { private set; get; }

        [JsonProperty("da_srednia")]
        public string MealAvarage { private set; get; }

        [JsonProperty("do_podst")]
        public List<string> MealBasic { private set; get; }

        [JsonProperty("do_wariant")]
        public List<string> MealWariant { private set; get; }

        [JsonProperty("do_wariant_lista1")]
        public List<string> MealWariant1 { private set; get; }

        [JsonProperty("do_wariant_lista2")]
        public List<string> MealWariant2 { private set; get; }

        [JsonProperty("do_dodat")]
        public List<string> MealSuplement { private set; get; }

        [JsonProperty("alergeny")]
        public List<string> Allergens { private set; get; }

        [JsonProperty("cena_podst")]
        public string BasicPrice { private set; get; }

        [JsonProperty("cena")]
        public string MealPrice { private set; get; }

        [JsonProperty("da_czas")]
        public string MealTime { private set; get; }

        [JsonProperty("waga")]
        public string MealWeight { private set; get; }

        [JsonProperty("kcal")]
        public string MealKcal { private set; get; }

        [JsonProperty("ud0_da_lubi")]
        public string MealLike { private set; get; }

       

        public Meal(string name, string kcal, string price, string weight, string photo, string category)
        {
            this.MealName = name;
            this.MealKcal = kcal.Insert(0,"Kcal: ");
            this.MealPrice = price.Insert(0, "Cena: ");
            this.MealWeight = weight.Insert(0, "Waga: ");
            this.MealPhoto = photo.Replace("_m","");
            this.MealCategory = category;
        }
        
    }
}