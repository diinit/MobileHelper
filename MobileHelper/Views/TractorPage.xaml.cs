using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TractorPage : ContentPage
    {
        public TractorPage(string Name, string Specifications, string source)
        {
            InitializeComponent();
            MyName.Text = Name;
            MySpecif.Text = Specifications;
            MyImage.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
    }
}