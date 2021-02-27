using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MobileINTEC.Views;
using Xamarin.Forms;

namespace MobileINTEC.ViewModels
{
    public class RegisterViewModel
    {
        public ICommand RegisterCommand { get; }
        public string User { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirmation { get; set; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(OnRegister);
        }
        private async void OnRegister()
        {
            if (string.IsNullOrEmpty(User) | string.IsNullOrEmpty(Email) | string.IsNullOrEmpty(Password) | string.IsNullOrEmpty(Confirmation))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Campo nombre, email y/o contraseña no puede estar vacío", "Ok");
            }
            else if (!Password.Equals(Confirmation))
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Las contraseñas deben coincidir", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
                await App.Current.MainPage.DisplayAlert("Bienvenido", $"Bienvenido {User}", "Ok");
            }
        }
    }
}
