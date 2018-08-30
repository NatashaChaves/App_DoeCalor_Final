using App_DoeCalor_Final.ViewModels;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App_DoeCalor_Final.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoadorPage : ContentPage
	{
		public DoadorPage ()
		{
			InitializeComponent ();
            this.BindingContext = new IndexPage();

            Mapas.MoveToRegion(MapSpan.FromCenterAndRadius(
                             new Position(-23.4859591, -47.4420192),
                             Distance.FromMiles(0.5)));
        }
        private async void GetPosition(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

            LongitudeLabel.Text = string.Format("{0:0.0000000}", position.Longitude);
            LatitudeLabel.Text = string.Format("{0:0.0000000}", position.Latitude);
        }
        private void Mapa_OnTap(object sender, TapEventArgs e)
        {
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = e.Position,
                Label = "Doador",
                Address = e.Position.Latitude + " X " + e.Position.Latitude,
            };

            Mapas.Pins.Add(pin);
        }
    }
}