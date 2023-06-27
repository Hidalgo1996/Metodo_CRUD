using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Metodo_CRUD.Models;

public partial class Cliente
{
    [Key]
    public int Id { get; set; }
    [Required]

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public string Telefono { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string Estado { get; set; }
}
