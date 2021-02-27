using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using MobileINTEC.Views;


namespace MobileINTEC.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand SignUpCommand{ get; }
        public string User { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            SignUpCommand = new Command(OnSignUp);
        }
    
        async void OnSignUp()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        private async void OnLogin()
        {
            if (string.IsNullOrEmpty(User) | string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Campo email y/o contraseña no puede estar vacío", "Ok");
            }

            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", $"Hola {User}", "Ok");
            }
        }
    }
}
