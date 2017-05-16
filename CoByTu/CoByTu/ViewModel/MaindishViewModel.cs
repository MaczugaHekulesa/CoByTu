using CoByTu.Data;
using CoByTu.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoByTu.ViewModel
{
    public class MaindishViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly INavigationService _navigationService;

        public DataManager dataManager;
        public List<Meal> Maindishes { get; set; }

        public MaindishViewModel(INavigationService navigationService)
        {

            Init();
            if (navigationService == null)
                throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;
        }

        public async void Init()
        {
            dataManager = new DataManager();
            Maindishes = await dataManager.GetMealsFromCategoryAsync("4");
        }
    }
}