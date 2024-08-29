using BarGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_Bar
{
    public class PedidoService
    {
        public void ProcesarPedido(Pedido pedido)
        {
            try
            {
                int total = pedido.CalcularTotal();
                Console.WriteLine($"Procesando pedido con total de: {total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar el pedido: {ex.Message}");
            }
        }
    }
}
 
