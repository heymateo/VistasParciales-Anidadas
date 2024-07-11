namespace VistasEjemplo.Models
{
    public class Paciente
    {
        public int Id_Paciente { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
