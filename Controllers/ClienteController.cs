using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ejercicio1.Models; // Asegúrate de importar el espacio de nombres donde se encuentra tu modelo Cliente

namespace Ejercicio1.Controllers
{
    public class ClienteController : Controller
    {
        // Acción para mostrar la lista de clientes
        public ActionResult Index()
        {
            List<Cliente> clientes = ObtenerClientesDesdeAlgunaFuente(); // Aquí deberías implementar tu lógica para obtener los clientes
            return View(clientes); // Devuelve la vista con la lista de clientes
        }

        // Acción para mostrar los detalles de un cliente específico
        public ActionResult Detalles(int id)
        {
            Cliente cliente = BuscarClientePorId(id); // Aquí deberías implementar tu lógica para buscar un cliente por su ID
            if (cliente == null)
            {
                
            }
            return View(cliente); // Devuelve la vista con los detalles del cliente
        }

        // Método de ejemplo para obtener una lista de clientes (simulado)
        private List<Cliente> ObtenerClientesDesdeAlgunaFuente()
        {
            // Aquí podrías implementar la lógica para obtener los clientes desde una base de datos, servicio web, etc.
            // Por simplicidad, aquí se simula una lista de clientes estática
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Juan", Apellido = "Pérez", Direccion = "Calle 123", Telefono = "555-1234", FechaNacimiento = new DateTime(1990, 5, 10) },
                new Cliente { Id = 2, Nombre = "María", Apellido = "González", Direccion = "Av. Principal", Telefono = "555-5678", FechaNacimiento = new DateTime(1985, 8, 20) },
                // Puedes agregar más clientes según sea necesario
            };
            return clientes;
        }

        // Método de ejemplo para buscar un cliente por su ID (simulado)
        private Cliente BuscarClientePorId(int id)
        {
            // Aquí podrías implementar la lógica para buscar un cliente por su ID en tu fuente de datos
            // Por simplicidad, aquí se simula la búsqueda en una lista estática de clientes
            return ObtenerClientesDesdeAlgunaFuente().FirstOrDefault(c => c.Id == id);
        }
    }
}
