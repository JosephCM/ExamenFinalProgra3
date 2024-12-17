using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaGestion.Models
{
    public class Empleado
    {

        public enum Categoria
        {
            Administrador,
            Operario,
            Peon
        }
    
    public Empleado()
        {
            CarnetUnico = string.Empty;
            NombreCompleto = string.Empty;
            Telefono = string.Empty;
            CorreoElectronico = string.Empty;
            CategoriaLaboral = string.Empty;
        }


        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El carnet único es obligatorio.")]
        public string CarnetUnico { get; set; }

        [Required(ErrorMessage = "El nombre completo es obligatorio.")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; } = "San José";

        [Required]
        [Phone(ErrorMessage = "El teléfono debe ser válido.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        public string CorreoElectronico { get; set; }

        [Range(250000, 500000, ErrorMessage = "El salario debe estar entre 250,000 y 500,000.")]
        public double Salario { get; set; } = 250000;

        [Required(ErrorMessage = "Debe especificar una categoría laboral.")]
        [RegularExpression("Administrador|Operario|Peón", ErrorMessage = "Categoría inválida.")]
        public string CategoriaLaboral { get; set; }
    }
}
