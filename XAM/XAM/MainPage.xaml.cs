using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Editor.Completed += Editor_Completed;
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            DisplayAlert("Titulo", "Termino de escribir", "Ok");
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Click en el boton", "Ok");
            Fecha.Date = DateTime.Now;
            Fecha.MinimumDate = new DateTime(2015, 01, 01);
            Fecha.MaximumDate = new DateTime(2025, 01, 01);        }

        private void piker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elemento = piker.SelectedItem as string;
            DisplayAlert("Mensaje", elemento, "Ok");
        }

        private void Sumilador_Clicked(object sender, EventArgs e)
        {
            progreso.ProgressTo(1, 5000, Easing.Linear);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando Resultado", "Ok");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDisplay.Text = Slider.Value.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDisplay.Text = Stepper.Value.ToString();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value)
                DisplayAlert("Mensaje", "Encendido", "Ok");
            else
                DisplayAlert("Mensaje", "Apagado", "Ok");


        }
    }
}
