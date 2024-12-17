namespace SistemaGestion.Models
{
    public class Asignacion
    {
        public int Id { get; set; }

        public int EmpleadoId { get; set; }
        public required Empleado Empleado { get; set; }

        public int ProyectoId { get; set; }
        public required Proyecto Proyecto { get; set; }

        public DateTime FechaAsignacion { get; set; } = DateTime.Now;
    }
}
