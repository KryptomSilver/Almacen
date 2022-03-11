using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public int codEmpleado { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string tipoUsuario { get; set; }
    }
}
