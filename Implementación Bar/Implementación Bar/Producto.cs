using BarGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_Bar
{
    public class Producto
    {
        public string ID { get; private set; }
        public string Nombre { get; private set; }
        public int Precio { get; private set; }

        public Producto(string id, string nombre, int precio)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("El ID del producto no puede estar vacío.");
            if (string.IsNullOrEmpty(nombre)) throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (precio <= 0) throw new ArgumentException("El precio del producto debe ser positivo.");

            ID = id;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
