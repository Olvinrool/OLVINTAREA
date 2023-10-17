using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OLVINTAREA.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class IngresarDatosPage : ContentPage
    {
        private Empleado empleado = new Empleado();

        public IngresarDatosPage()
        {
            InitializeComponent();
            BindingContext = empleado;
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            var context = new ValidationContext(empleado, null, null);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(empleado, context, results, true))
            {
                await Navigation.PushModalAsync(new ResultadoPage() { BindingContext = empleado });
            }
            else
            {
                var errors = results.Select(result => result.ErrorMessage);
                await DisplayAlert("Error", string.Join("\n", errors), "OK");
            }
        }
    }


}