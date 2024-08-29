using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarGestion
{
    
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Usuario(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void IniciarSesion(string id)
        {
            
            Console.WriteLine($"{Nombre} ha iniciado sesión.");
        }

        public void CerrarSesion()
        {
           
            Console.WriteLine($"{Nombre} ha cerrado sesión.");
        }
    }

    
    public class Mesero : Usuario
    {
        public List<Mesa> MesasAsignadas { get; set; }
        public int ClientesAtendidos { get; set; }
        public List<int> Propinas { get; set; }

        public Mesero(string id, string nombre) : base(id, nombre)
        {
            MesasAsignadas = new List<Mesa>();
            Propinas = new List<int>();
            ClientesAtendidos = 0;
        }

        public void RegistrarPedido(Mesa mesa, Pedido pedido)
        {
            
            mesa.RegistrarPedido(pedido);
        }

        public void LiquidarFactura(Factura factura)
        {
            
            factura.PagarFactura();
            Console.WriteLine($"Factura {factura.Id} liquidada.");
        }
    }

    
    public class Administrador : Usuario
    {
        public Administrador(string id, string nombre) : base(id, nombre) { }

        public void VerPropinasMeseros(List<Mesero> meseros)
        {
           
            foreach (var mesero in meseros)
            {
                int totalPropinas = 0;
                foreach (var propina in mesero.Propinas)
                {
                    totalPropinas += propina;
                }
                Console.WriteLine($"Mesero {mesero.Nombre}: {totalPropinas} en propinas.");
            }
        }

        public void VisualizarMesas(GestorMesa gestorMesa)
        {
            
            gestorMesa.MostrarMesas();
        }

        public void VerEfectividadMesero(Mesero mesero)
        {
           
            Console.WriteLine($"Mesero {mesero.Nombre} ha atendido {mesero.ClientesAtendidos} clientes.");
        }
    }
}
