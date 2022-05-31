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
using System.Windows.Shapes;

namespace JoseManuelSanchezRubio34
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public Producto Value { get; set; }

        private void btnGuardarClick(object sender, RoutedEventArgs e)
        {
            Value = new Producto(txtNombre.Text, txtDescripcion.Text, txtCategoria.Text, Convert.ToInt32(txtPrecio.Text));
            DialogResult = true;
        }

        private void btnCancelarClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
