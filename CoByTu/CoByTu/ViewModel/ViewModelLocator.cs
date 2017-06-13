using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace CoByTu.ViewModel
{
    public class ViewModelLocator
    {
        public const string MainCarouselPage = "MainCarouselPage";
        public const string DrinksPage = "DrinksPage";
        public const string MaindishPage = "MaindishPage";
        public const string MasterDetail = "MasterDetailPage";
        public const string SoupView = "SoupViewPage";

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            
            SimpleIoc.Default.Register<MaindishViewModel>();
            SimpleIoc.Default.Register<DrinksViewModel>();
            SimpleIoc.Default.Register<SoupViewModel>();
            
        }

     

        public MaindishViewModel Maindish
        {
            get { return ServiceLocator.Current.GetInstance<MaindishViewModel>(); }
        }

        public DrinksViewModel Drink
        {
            get { return ServiceLocator.Current.GetInstance<DrinksViewModel>(); }
        }

        public SoupViewModel Soup
        {
            get { return ServiceLocator.Current.GetInstance<SoupViewModel>(); }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }

}
