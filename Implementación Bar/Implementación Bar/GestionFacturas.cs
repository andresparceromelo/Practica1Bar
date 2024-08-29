using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_Bar
{
    public class FacturaService
    {
        public void GenerarFactura(Pedido pedido)
        {
            try
            {
                int total = pedido.CalcularTotal();
                Console.WriteLine($"Factura generada. Total: {total}");
                pedido.ActualizarEstado(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar la factura: {ex.Message}");
            }
        }
    }
}

