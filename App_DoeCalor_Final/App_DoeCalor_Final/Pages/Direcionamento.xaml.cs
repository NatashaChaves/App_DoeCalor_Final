using App_DoeCalor_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_DoeCalor_Final.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Direcionamento : ContentPage
	{
		public Direcionamento ()
		{
			InitializeComponent ();
            this.BindingContext = new Direcionar();
        }
	}
}