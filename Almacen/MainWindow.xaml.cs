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
        public void  getProducts()
        {
          
        }
        public MainWindow()
        {
            InitializeComponent();
            getProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
