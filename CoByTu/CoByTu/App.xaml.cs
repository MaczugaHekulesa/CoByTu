using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using CoByTu.Services;
using CoByTu.ViewModel;
using Xamarin.Forms;
using CoByTu.Views;

namespace CoByTu
{
    public partial class App : Application
    {
        public App()
        {
            var nav = new NavigationService();

            nav.Configure(ViewModelLocator.MainCarouselPage, typeof(MainCarouselPage));
            nav.Configure(ViewModelLocator.DrinksPage, typeof(DrinksPage));
            nav.Configure(ViewModelLocator.MaindishPage, typeof(MaindishPage));
            nav.Configure(ViewModelLocator.SoupView, typeof(SoupView));


            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var mainPage = new NavigationPage(new MainPage());

            nav.Initialize(mainPage);

            MainPage = mainPage;
        }

        private static readonly ViewModelLocator _locator = new ViewModelLocator();
        public static ViewModelLocator Locator
        {
            get { return _locator; }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
