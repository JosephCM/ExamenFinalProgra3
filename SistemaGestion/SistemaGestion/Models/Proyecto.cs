namespace SistemaGestion.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Proyecto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código del proyecto es obligatorio.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre del proyecto es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFin { get; set; }
        public Proyecto()
        {
            Codigo = string.Empty;  
            Nombre = string.Empty;  
        }
    }
}
