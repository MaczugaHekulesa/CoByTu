using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class CaruselHeaders : ContentPage
    {
        public CaruselHeaders(string name)
        {
            this.name = name;
            
        }

        public string name { private set; get; }


        public override string ToString()
        {
            return name;
        
            InitializeComponent();
        }
    }
}
