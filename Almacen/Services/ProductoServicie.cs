using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacen.Models;
using Npgsql;

namespace Almacen.Services
{
    internal class ProductoServicie : IProductos
    {
        Connection server = new Connection();
        public Producto actualizarProducto(int claveProducto)
        {
            throw new NotImplementedException();
        }

        public string eliminarProducto(int claveProducto)
        {
            NpgsqlConnection conn = server.obtenerConexion();
            conn.Open();
            string commandoSQL;
            commandoSQL = "DELETE FROM productos where clave = '" + claveProducto+"')";
            NpgsqlCommand command = new NpgsqlCommand(commandoSQL, conn);
            int res = command.ExecuteNonQuery();
            if (res > 0)
            {
                return "Producto eliminado";
            }
            else
            {
                return "No sepudo eliminar";
            }
        }

        public Producto obtenerProducto(int claveProducto)
        {
            throw new NotImplementedException();
        }

        public List<Producto> obtenerProductos()
        {
            NpgsqlConnection conn = server.obtenerConexion();
            List<Producto> productos = new List<Producto>();
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * from productos", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                productos.Add(new Producto()
                {
                    clave = (int)dr[0],
                    nombre = (string)dr[1],
                });
            }
            return productos;
        }
    }
}
