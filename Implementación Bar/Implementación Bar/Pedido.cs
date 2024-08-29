using BarGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_Bar
{
    public class Pedido
    {
        public string ID { get; private set; }
        public Dictionary<Producto, int> Productos { get; private set; }
        public bool Estado { get; private set; }
        public Usuario Mesero { get; private set; }

        public Pedido(string id, Mesero mesero)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("El ID del pedido no puede estar vacío.");
            if (mesero == null) throw new ArgumentNullException(nameof(mesero), "El mesero no puede ser nulo.");

            ID = id;
            Mesero = mesero;
            Productos = new Dictionary<Producto, int>();
            Estado = false; 
        }

        public void AgregarProducto(Producto producto, int cantidad)
        {
            if (producto == null) throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            if (cantidad <= 0) throw new ArgumentException("La cantidad debe ser mayor a cero.");

            if (Productos.ContainsKey(producto))
            {
                Productos[producto] += cantidad;
            }
            else
            {
                Productos.Add(producto, cantidad);
            }
        }

        public void EliminarProducto(Producto producto)
        {
            if (producto == null) throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            if (!Productos.ContainsKey(producto)) throw new KeyNotFoundException("El producto no está en el pedido.");

            Productos.Remove(producto);
        }

        public int CalcularTotal()
        {
            int total = 0;

            foreach (var item in Productos)
            {
                total += item.Key.Precio * item.Value;
            }

            return total;
        }

        public void ActualizarEstado(bool nuevoEstado)
        {
            Estado = nuevoEstado;
        }
    }
}


