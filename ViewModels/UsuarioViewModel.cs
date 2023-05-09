using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Models;

namespace Parcial1.ViewModels
{
    public class UsuarioViewModels
    {
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public string ? NameFilter   { get; set; }
        public string ? ApellidoFilter { get; set; }
        public string ? NacionalidadFilter { get; set; }
    }
}  