using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Models
{
    public interface IProductos
    {
        public Producto obtenerProducto(int claveProducto);
        public List<Producto> obtenerProductos();
        public string eliminarProducto(int claveProducto);
        public Producto actualizarProducto(int claveProducto);

    }
}
