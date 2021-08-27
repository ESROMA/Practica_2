using Practica_2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica_2.ViewsModels
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MainPageVM()
        {
        }

        public Command loginButton 
        {
            get
            {
                return new Command(Checks);
            } 
        }
        private void Checks()
        {
            if (string.IsNullOrEmpty(txtEmail) && string.IsNullOrEmpty(txtPassword))
            {
                App.Current.MainPage.DisplayAlert("Advertencia!!", "Dejó ambos campos vacios.", "Aceptar");
            }
            else if (string.IsNullOrEmpty(txtEmail))
            {
                App.Current.MainPage.DisplayAlert("Advertencia!!", "Dejó el Email vacio.", "Aceptar");
            }
            else if (string.IsNullOrEmpty(txtPassword))
            {
                App.Current.MainPage.DisplayAlert("Advertencia!!", "Dejó la contraseña vacia.", "Aceptar");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Bienvenido", txtEmail, "Aceptar");
            }
        }

        private string testEmail;
        public string txtEmail
        {
            get { return testEmail; }
            set
            {
                testEmail = value;
                PropertyChanged(this, new PropertyChangedEventArgs("txtEmail"));
            }
        }
        private string testPassword;
        public string txtPassword
        {
            get { return testPassword; }
            set
            {
                testPassword = value;
                PropertyChanged(this, new PropertyChangedEventArgs("txtPassword"));
            }
        }

    }

}
