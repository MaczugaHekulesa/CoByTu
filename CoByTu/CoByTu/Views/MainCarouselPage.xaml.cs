using CoByTu.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoByTu.Data;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace CoByTu.Views
{
    public partial class MainCarouselPage : CarouselPage
    {
        
        public MainCarouselPage()
        {   
            InitializeComponent();
            this.Children.Add(new MaindishPage());
            this.Children.Add(new DrinksPage());
            this.Children.Add(new SoupView());
        }
    }
}
