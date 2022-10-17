using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EJERCICIO1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Operation_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnum1.Text) || string.IsNullOrWhiteSpace(txtnum2.Text))
            {
                message("Alerta", "Debe escribir ambos numeros");
                return;
            }

            decimal num1 = decimal.Parse(txtnum1.Text);
            decimal num2 = decimal.Parse(txtnum2.Text);
            decimal result;


            if (sender.Equals(btnsuma))
            {
                result = num1 + num2;
            }
            else if (sender.Equals(btnresta))
            {
                result = num1 - num2;
            }
            else if (sender.Equals(btdivision))
            {
                if (num2 == 0)
                {
                    message("Alerta", "El segundo numero no puede ser 0");
                    return;
                }
                result = num1 / num2;
            }
            else
            {
                result = num1 * num2;
            }
            await Navigation.PushAsync(new Views.Resultado(result));
        }

        private async void message(string title, string description)
        {
            await DisplayAlert(title, description, "OK");
        }

       
    }
}

