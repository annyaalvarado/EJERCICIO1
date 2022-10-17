using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public Resultado()
        {
            InitializeComponent();
        }
        public Resultado (decimal result)
        {
            InitializeComponent();

            txtResult.Text = "El resultado es :" + result.ToString("0.##");
        }
    }
}