using BarGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_Bar
{
    public class Mesero
    {
        public string Nombre { get; private set; }
        public string ID { get; private set; }

        public Mesero(string nombre, string id)
        {
            if (string.IsNullOrEmpty(nombre)) throw new ArgumentException("El nombre del mesero no puede estar vacío.");
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("El ID del mesero no puede estar vacío.");

            Nombre = nombre;
            ID = id;
        }

        public void RegistrarPedido(Pedido pedido, Producto producto, int cantidad)
        {
            try
            {
                pedido.AgregarProducto(producto, cantidad);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar el pedido: {ex.Message}");
            }
        }

        public void LiquidarFactura(Pedido pedido)
        {
            try
            {
                int total = pedido.CalcularTotal();
                Console.WriteLine($"Factura liquidada. Total a pagar: {total}");
                pedido.ActualizarEstado(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al liquidar la factura: {ex.Message}");
            }
        }
    }
}

