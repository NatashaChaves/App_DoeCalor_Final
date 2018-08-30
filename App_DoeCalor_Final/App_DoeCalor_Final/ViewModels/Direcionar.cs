using App_DoeCalor_Final.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_DoeCalor_Final.ViewModels
{
    public class Direcionar
    {
        public ICommand DirecionarDoadorCommand { get; set; }
        public ICommand DirecionarRecptorCommand { get; set; }

        public Direcionar()
        {
            DirecionarDoadorCommand = new Command(DirecionaDoador);
            DirecionarRecptorCommand = new Command(DirecionaReceptor);
         }
        private async void DirecionaDoador()
        {
            await App.Current.MainPage.Navigation.PushAsync(new DoadorPage());

        }
        private async void DirecionaReceptor()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ReceptorPage());
        }
    }
}
