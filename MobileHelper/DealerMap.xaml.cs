using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MobileHelper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DealerMap : ContentPage
    {
        public DealerMap()
        {
            InitializeComponent();
            Task.Delay(2000);
            UpdateMap();
        }

        List<DealerPlace> placesList = new List<DealerPlace>();

        private async void UpdateMap()
        {
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(DealerMap)).Assembly;
                Stream stream = assembly.GetManifestResourceStream("MobileHelper.DealerPlaces.json");
                string text = string.Empty;
                using (var reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }

                var resultObject = JsonConvert.DeserializeObject<DealerPlaces>(text);

                foreach (var place in resultObject.results)
                {
                    //byte[] conv = Encoding.Default.GetBytes(place.name);
                    //place.name = Encoding.UTF8.GetString(conv);
                    placesList.Add(new DealerPlace
                    {
                        
                        PlaceName = place.name,
                        Address = place.vicinity,
                        Location = place.geometry.location,
                        Position = new Position(place.geometry.location.lat, place.geometry.location.lng),
                        //Icon = place.icon,
                        //Distance = $"{GetDistance(lat1, lon1, place.geometry.location.lat, place.geometry.location.lng, DistanceUnit.Kiliometers).ToString("N2")}km",
                        //OpenNow = GetOpenHours(place?.opening_hours?.open_now)
                    });;

                }

                MyMap.ItemsSource = placesList;
                //PlacesListView.ItemsSource = placesList;
                //var loc = await Xamarin.Essentials.Geolocation.GetLocationAsync();
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(53.127068, 29.194726), Distance.FromKilometers(100)));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}