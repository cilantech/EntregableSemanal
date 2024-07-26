using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public class Persona
{
    protected Guid Id { get; set; }
    protected string Nombre { get; set; }
    protected string Apellido { get; set; }

    protected string TipoDocumento { get; set; }

    protected int NumeroDocumento { get; set; }

    protected string Email { get; set; }

    protected string Telefono { get; set; }


    public Persona(string nombre, string apellido, string tipoDocumento, int numeroDocumento, string email, string telefono)
    {
        Id = new Guid();
        Nombre = nombre;
        Apellido = apellido;
        TipoDocumento = tipoDocumento;
        NumeroDocumento = numeroDocumento;
        Email = email;
        Telefono = telefono;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"viendo detalles de : ");
        Console.WriteLine(Id);
        Console.WriteLine(Nombre);
        Console.WriteLine(Apellido);
        Console.WriteLine(TipoDocumento);
        Console.WriteLine(NumeroDocumento);
        Console.WriteLine(Email);
        Console.WriteLine(Telefono);

    }


}
