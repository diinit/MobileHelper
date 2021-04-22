using MobileHelper.Models;
using MobileHelper.ViewModels;
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
    public partial class TracrorList : ContentPage
    {
        public TracrorList()
        {
            InitializeComponent();
            BindingContext = new TractorListVM();
        }

        private async void Item_Selected(Object sendor, ItemTappedEventArgs e)
        {
            var details = e.Item as TractorListM;
            await Navigation.PushAsync(new TractorPage(details.Name, details.Specifications, details.Image));
        }
    }
}