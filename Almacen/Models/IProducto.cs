using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Models
{
    public interface IProducto
    {
       public int clave { get; set; }
       public string nombre { get; set; }
    }
}
