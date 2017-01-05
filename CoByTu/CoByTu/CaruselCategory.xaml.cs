using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoByTu
{
    public partial class CaruselCategory : ContentPage
    {
        public CaruselCategory( bool includeBigLabel)
        {
            Func<string, string, Label> CreateLabel = (string source, string fmt) => {
                Label label = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    HorizontalTextAlignment = TextAlignment.End
                };
                label.SetBinding(Label.TextProperty,
                    new Binding(source, BindingMode.OneWay, null, null, fmt));

                return label;
            };

            if (includeBigLabel)
            {
                Label bigLabel = new Label
                {
                    FontSize = 50,
                    HorizontalOptions = LayoutOptions.Center
                };
                bigLabel.SetBinding(Label.TextProperty, "Name");

                (this.Content as StackLayout).Children.Insert(0, bigLabel);
            }
            InitializeComponent();
        }
    }
}
