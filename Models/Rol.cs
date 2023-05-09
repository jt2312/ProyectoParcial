using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    public class Rol
    {
        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "ID")]
        public int  Id { get; set; }
        [EmailAddress (ErrorMessage = "El valor ingresado no es una dirección de correo electrónico válida")]
        [Display(Name = "Mail")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Rol")]
        public string DescripcionRol { get; set; }
        
        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Es PRofesor?")]
        public bool Esprofesor{ get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        [Display(Name = "Es PRofesor?")]
        public bool EsAlumno{ get; set; }

        public int UsuarioId { get; set; }
        
        

    }
}