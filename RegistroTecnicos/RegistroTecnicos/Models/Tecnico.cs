using System.ComponentModel.DataAnnotations;

namespace RegistroTecnicos.Models;

public class Tecnico
{
    [Key]
    public int TecnicoId { get; set; }
    public string? Nombre { get; set; }
    public int SueldoHora { get; set; }
}
