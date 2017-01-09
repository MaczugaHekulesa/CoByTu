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


        public string MealId { private set; get; }
        public string UserId { private set; get; }
        public string MealPhoto { private set; get; }
        public string Restaurant { private set; get; }
        public string MealCategory { private set; get; }
        public List<String> Subcategory { private set; get; }
        public string MealType { private set; get; }
        public string MealName { private set; get; }
        public string MealDescription { private set; get; }
        public string MealAvarage { private set; get; }
        public List<String> MealBasic { private set; get; }
        public List<String> MealWariant { private set; get; }
        public List<String> MealWariant1 { private set; get; }
        public List<String> MealWariant2 { private set; get; }
        public List<String> MealSuplement { private set; get; }
        public List<String> Allergens { private set; get; }
        public string BasicPrice { private set; get; }
        public string MealPrice { private set; get; }
        public string MealTime { private set; get; }
        public string MealWeight { private set; get; }
        public string MealKcal { private set; get; }
        public string MealLike { private set; get; }


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
            var meals = JsonConvert.DeserializeObject<List<Meal>>(response);// jak i gdzie stworzyć argument "response"? dokąd to wrzucić, by mogło odczytać prawidłowo zaciągnięte dane?
            return MealName + " : " + MealKcal + " : " + MealPhoto + " : " + MealPrice + " : " + MealWeight;


        }
    }
 }
