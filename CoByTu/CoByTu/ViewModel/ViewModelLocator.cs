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

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MaindishViewModel>();
            SimpleIoc.Default.Register<DrinksViewModel>();
        }

        public MainViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

        public MaindishViewModel Maindish
        {
            get { return ServiceLocator.Current.GetInstance<MaindishViewModel>(); }
        }

        public DrinksViewModel Drink
        {
            get { return ServiceLocator.Current.GetInstance<DrinksViewModel>(); }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
