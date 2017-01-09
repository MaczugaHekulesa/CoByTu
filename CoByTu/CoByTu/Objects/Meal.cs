using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoByTu
{
    class Meal
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
        public List<String> Subcategory { private set; get; }

        [JsonProperty("da_rodzaj")]
        public string MealType { private set; get; }

        [JsonProperty("da_nazwa")]
        public string MealName { private set; get; }

        [JsonProperty("da_opis")]
        public string MealDescription { private set; get; }

        [JsonProperty("da_srednia")]
        public string MealAvarage { private set; get; }

        [JsonProperty("do_podst")]
        public List<String> MealBasic { private set; get; }

        [JsonProperty("do_wariant")]
        public List<String> MealWariant { private set; get; }

        [JsonProperty("do_wariant_lista1")]
        public List<String> MealWariant1 { private set; get; }

        [JsonProperty("do_wariant_lista2")]
        public List<String> MealWariant2 { private set; get; }

        [JsonProperty("do_dodat")]
        public List<String> MealSuplement { private set; get; }

        [JsonProperty("alergeny")]
        public List<String> Allergens { private set; get; }

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



        public Meal(string name, string kcal, string price, string weight, string photo)
        {
            this.MealName = name;
            this.MealKcal = kcal;
            this.MealPrice = price;
            this.MealWeight = weight;
            this.MealPhoto = photo;
        }          

        public Meal(string da_id,string da_uz_id, string da_foto, string da_gdzie, string da_kategoria, List<String> da_podkategoria, string da_rodzaj,
            string da_nazwa, string da_opis, string da_srednia, List<String> da_podst, List<String> do_wariant, List<String> do_wariant_lista1, List<String> do_wariant_lista2,
            List<String> do_dodat, List<String> alergeny, string cena_podst, string cena, string da_czas, string waga , string kcal, string udo_da_lubi)  //Klasa odpowiadajca za nazwe kategorii
        {
            this.MealId = da_id;
            this.UserId = da_uz_id;
            this.MealPhoto = da_foto;
            this.Restaurant=da_gdzie;
            this.MealCategory = da_kategoria;
            this.Subcategory = da_podkategoria;
            this.MealType = da_rodzaj;
            this.MealName = da_nazwa;
            this.MealDescription = da_opis;
            this.MealAvarage = da_srednia;
            this.MealBasic = da_podst;
            this.MealWariant = do_wariant;
            this.MealWariant1 = do_wariant_lista1;
            this.MealWariant2 = do_wariant_lista2;
            this.MealSuplement = do_dodat;
            this.Allergens = alergeny;
            this.BasicPrice = cena_podst;
            this.MealPrice = cena;
            this.MealTime = da_czas;
            this.MealWeight = waga;
            this.MealKcal = kcal;
            this.MealLike = udo_da_lubi;



        }
        
        public override string ToString()
        {
            //var meals = JsonConvert.DeserializeObject<List<Meal>>(response);// jak i gdzie stworzyć argument "response"? dokąd to wrzucić, by mogło odczytać prawidłowo zaciągnięte dane?
            return MealName + " : " + MealKcal + " : " + MealPhoto + " : " + MealPrice + " : " + MealWeight;


        }
    }
 }
