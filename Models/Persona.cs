using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public class Persona
{
    public Guid Id { get; set; }
    public string NombreEstudiante { get; set; }

    public string ApellidoEstudiante { get; set; }

    public string TipoDocumento { get; set; }

    public int NumeroDocumento { get; set; }

    public string Email { get; set; }

    public string Telefono { get; set; }


    public void MostrarDetalles()
    {
        Console.WriteLine("viendo detalles de ");
    }

    public Persona(string nombreEstudiante,string apellidoEstudiante,string tipoDocumento, int numeroDocumento,string email,string telefono)
    {

        NombreEstudiante = nombreEstudiante;
        ApellidoEstudiante = apellidoEstudiante;
        TipoDocumento = tipoDocumento;
        NumeroDocumento = numeroDocumento;
        Email = email;
        Telefono = telefono;
    }


}
