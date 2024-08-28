using System.ComponentModel.DataAnnotations;

namespace RegistroTecnicos.Models;

public class Tecnico
{
    [Key]
    public int EstudianteId { get; set; }
    public string? Nombre { get; set; }
    public int SueldoHora { get; set; }
}
