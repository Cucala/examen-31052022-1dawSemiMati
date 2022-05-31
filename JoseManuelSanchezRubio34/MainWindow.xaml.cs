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

namespace JoseManuelSanchezRubio34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listProductos.ItemsSource = products;
            products = new List<Producto>();
        }

        public List<Producto> products { get; set; }

        private void btnAñadirProductoClick(object sender, RoutedEventArgs e)
        {
            var viewAddProduct = new AddProduct()
            {
                Owner = this
            };

            if (viewAddProduct.ShowDialog() == true)
            {
                products.Add(viewAddProduct.Value);
            }
            viewAddProduct.Close();
        }

        private void btnAñadirACarritoClick(object sender, RoutedEventArgs e)
        {
            var viewProduct = new Product()
            {
                Owner = this
            };

            if (viewProduct.ShowDialog() == true)
            {
                products.Add(viewProduct.Value);
            }
            viewProduct.Close();
        }
    }
}
