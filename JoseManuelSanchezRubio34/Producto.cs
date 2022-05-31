using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseManuelSanchezRubio34
{
    public class Producto
    {
        public string nombre;
        public string descripcion;
        public string categoria;
        public int precio;


        public Producto(string nombre, string descripcion, string categoria, int precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.precio = precio;

        }
    }
}
