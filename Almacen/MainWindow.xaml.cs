using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Npgsql;

namespace Almacen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connection server = new Connection();
        public class Producto
        {
            public int clave { get; set; }
            public string Nombre { get; set; }
        }
        public void  getProducts()
        {
            NpgsqlConnection conn = server.openConnection();
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * from productos", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (dr.Read())
            {
                productos.Add(new Producto()
                {
                    clave = (int)dr[0],
                    Nombre = (string)dr[1],
                });
            }
            data.ItemsSource = productos;
        }
        public MainWindow()
        {
            InitializeComponent();
            getProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NpgsqlConnection conn = server.openConnection();
            conn.Open();
            string commandoSQL;
            string input = nombreInput.Text;
            commandoSQL = "INSERT INTO productos (nombre) VALUES('"+ input +" ')";
            NpgsqlCommand command = new NpgsqlCommand(commandoSQL, conn);
            int res = command.ExecuteNonQuery();
            if (res > 0)
            {
                getProducts();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
