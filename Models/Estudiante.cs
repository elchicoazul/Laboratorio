using System;
using System.ComponentModel.DataAnnotations;

namespace LABORATORIO.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombres")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellidos")]
        public String LastName { get; set; }

        [Display(Name="Curso")]
        public String Email { get; set; }

                public String Message { get; set; }

        public String Response { get; set; }

    }
}