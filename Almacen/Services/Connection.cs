using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace Almacen
{
    public class Connection
    {
        public NpgsqlConnection obtenerConexion()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            string uriConnection;
            uriConnection = "Host=127.0.0.1;User Id=postgres;Password=1234;Database=almacen";
            conn.ConnectionString = uriConnection;
            return conn;
        }        
    }
}
