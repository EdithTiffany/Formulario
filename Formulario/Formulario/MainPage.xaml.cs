using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Guardar_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("hola", nombre1.Text + "\n" + apellido2.Text + "\n" + direccion3.Text + "\n" + telefono4.Text + "\n" + carrera5.Text + "\n" + semestre6.Text + "\n" + matricula7.Text + "\n" + correo8.Text + "\n" + github9.Text, "Good");
        }
    }
}
