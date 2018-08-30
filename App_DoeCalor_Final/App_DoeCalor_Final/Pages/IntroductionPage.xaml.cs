using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App_DoeCalor_Final.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : CarouselPage
    {
		public IntroductionPage ()
		{
			InitializeComponent ();
		}
         public void VerifyInternet(object sender, EventArgs e)
	        {
	                Status.Text = CrossConnectivity.Current.IsConnected ? "Connected" : "Disconnected";
	        }
	}
}