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
	public partial class HomePage : TabbedPage
    {
		public HomePage ()
		{
			InitializeComponent ();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                              new Position(-23.4859591, -47.4420192),
                              Distance.FromMiles(0.5)));



            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-23.4859591, -47.4420192),
                Label = "Demo Maps",
                Address = "www.julianocustodio.com",
                BindingContext = "24993283147",
            };

            Mapa.Pins.Add(pin);
        }


       
       
    }
}