using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OLVINTAREA
{
    public class Empleado
    {
        [Required(ErrorMessage = "El campo 'Nombres' es obligatorio.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo 'Apellidos' es obligatorio.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo 'Fecha de Nacimiento' es obligatorio.")]
        public DateTime FechaNacimiento { get; set; }

        [RegularExpression(@"^[\w\.-]+@[\w\.-]+\.\w+$", ErrorMessage = "El correo electrónico no es válido.")]
        public string Correo { get; set; }
    }
}
