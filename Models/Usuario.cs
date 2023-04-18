using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    public class Usuario
    {
            public int ID { get; set; }
            public string Usuarioo { get; set; }
            public string Contraseña { get; set; }  
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime fechanacimiento { get; set; }
            public string genero { get; set; }
            public int documento { get; set; }
            public string nacionalidad { get; set; }
            public string domicilio { get; set; }
            public int telefono { get; set; }
            public bool terminos { get; set; }

    }
}