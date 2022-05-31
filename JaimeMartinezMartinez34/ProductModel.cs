using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaimeMartinezMartinez34
{
    internal class ProductModel
    {
        public class Producto
        {
            private string Nombre;
            private string Descripcion;
            private string Categoria;
            private int Precio;


            public Producto(string nombre, string descripcion, string categoria, int precio)
            {
                this.Nombre = nombre;
                this.Descripcion = descripcion;
                this.Categoria = categoria;
                this.Precio = precio;

            }

            public static string Nombre { get => nombre; set => nombre = value; }
            public static string Categoria { get => categoria; set => categoria = value; }
            
            public static string Descripcion { get => Descripcion; set => Descripcion = value; }
            public int Precio { get => precio; set => this.precio = value; }

        }
    }
}