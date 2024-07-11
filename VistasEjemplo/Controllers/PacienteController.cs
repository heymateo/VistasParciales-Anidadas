using Microsoft.AspNetCore.Mvc;
using VistasEjemplo.Models;

namespace VistasEjemplo.Controllers
{
    public class PacienteController : Controller
    {
        private static List<Paciente> pacientes = new List<Paciente>
        {
            new Paciente { Id_Paciente = 1, Nombre = "Juan Perez", FechaNacimiento = new DateOnly(1985, 5, 12), Correo = "juan.perez@example.com", Telefono = "12345678" },
            new Paciente { Id_Paciente = 2, Nombre = "Maria Lopez", FechaNacimiento = new DateOnly(1990, 8, 23), Correo = "maria.lopez@example.com", Telefono = "87654321" }
        };
        public IActionResult Index()
        {
            return View(pacientes);
        }

        public IActionResult Edit(int id)
        {
            var paciente = pacientes.FirstOrDefault(p => p.Id_Paciente == id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        [HttpPost]
        public IActionResult Edit(Paciente paciente)
        {
            var existingPaciente = pacientes.FirstOrDefault(p => p.Id_Paciente == paciente.Id_Paciente);
            if (existingPaciente == null)
            {
                return NotFound();
            }

            existingPaciente.Nombre = paciente.Nombre;
            existingPaciente.FechaNacimiento = paciente.FechaNacimiento;
            existingPaciente.Correo = paciente.Correo;
            existingPaciente.Telefono = paciente.Telefono;

            return RedirectToAction(nameof(Index));
        }
    }
}
