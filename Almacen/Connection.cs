using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace Almacen
{
    internal class Connection
    {
        public void openConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            string uriConnection;
            uriConnection = "Host=127.0.0.1;User Id=postgres;Password=1234;Database=almacen";
            conn.ConnectionString = uriConnection;
            try
            {
                conn.Open();
                MessageBox.Show("Base de datos conectada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar la base de datos");
            }
        }

    }
}
