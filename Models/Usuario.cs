using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    public class Usuario

    {
        [Required(ErrorMessage = "Debe completar este campo")]
         [Display(Name = "ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        [MaxLength(20)]
        [MinLength(3)]            
         [Display(Name = "Usuario")]
        public string Usuarioo { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        [MinLength(8)]
        public string Contraseña { get; set; }  
        [Required(ErrorMessage = "Debe completar este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime fechanacimiento { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Genero")]
        public string genero { get; set; }

        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Documento")]
        public int documento { get; set; }

        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Nacionalidad")]
        public string nacionalidad { get; set; }

        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Domicilio")]
        public string domicilio { get; set; }
        [Display(Name = "Telefono")]
            
        [Required(ErrorMessage = "Debe completar este campo")]
        [Range(1100000000, 1199999999, ErrorMessage = "El número és inválido")]
        public int telefono { get; set; }
        [Display(Name = "Terminos")]
        public bool terminos { get; set; }

    }
}