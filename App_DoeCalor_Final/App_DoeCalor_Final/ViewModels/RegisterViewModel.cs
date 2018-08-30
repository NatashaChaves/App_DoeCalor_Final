using App_DoeCalor_Final.Helpers;
using App_DoeCalor_Final.Models;
using App_DoeCalor_Final.Pages;
using App_DoeCalor_Final.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_DoeCalor_Final.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand RegisterCommand { get; set; }
    
       

        private Usuario _usuario;
        public Usuario Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
                NotifyPropertyChanged("Usuario");
            }
        }
       
        private string _erro;
        public string Erro
        {
            get
            {
                return _erro;
            }

            set
            {
                _erro = value;
                NotifyPropertyChanged("Erro");
            }
        }

        public RegisterViewModel()
        {
    
            this.RegisterCommand = new Command(Register);
            Usuario = new Usuario();
           
        }
       

        private void Register()
        {
            try
            {
                UsuarioService.Insert(Usuario);
                Usuario.Email = Settings.Email;
                Usuario.Name = Settings.Name;

                App.Current.MainPage = new Direcionamento();
            }
            catch (Exception ex)
            {
                Erro = ex.Message;
            }
        }
    }
}
