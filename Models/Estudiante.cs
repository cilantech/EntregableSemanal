using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public class Estudiante : Persona
{
    public string NombreAcudiente { get; set; }
    public string CursoActual { get; set; }
    public DateOnly FechaNaciemiento { get; set; }
    public List<double> Calificaciones { get; set; } = new List<double>();



    public Estudiante(string nombre,string apellido,string tipoDocumento, int numeroDocumento,string email,string telefono,string nombreAcudiente, string cursoActual, DateOnly fechaNaciemiento, List<double> calificaciones):base(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono)
    {
        NombreAcudiente = nombreAcudiente;
        CursoActual = cursoActual;
        FechaNaciemiento = fechaNaciemiento;
        Calificaciones = calificaciones;
    }

    //metodo toString
    public override string ToString()
    {
        return $"Estudiante: {Nombre} {Apellido}, Documento: {TipoDocumento} {NumeroDocumento}, Email: {Email}, Telefono: {Telefono}, Nombre Acudiente: {NombreAcudiente}, Curso Actual: {CursoActual}, Fecha Nacimiento: {FechaNaciemiento.ToShortDateString()}";
    }
// agregar calificaciones
    public void AgregarNota(double calificacion)
    {
            Calificaciones.Add(calificacion);
    }

    public void AgregarNotas(double calificacion)
    {
        var nota = Calificaciones;
  
    }

    public void CalcularPromedio()
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }

     public void CalcularEdad()
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
        
    }

    public virtual void MostrarDetalles(){

        Console.WriteLine($"viendo detalles de : ");
        Console.WriteLine(Nombre);
        Console.WriteLine(Apellido);
        Console.WriteLine(TipoDocumento);
        Console.WriteLine(NumeroDocumento);
        Console.WriteLine(Email);
        Console.WriteLine(Telefono);
        Console.WriteLine(NombreAcudiente);

    }


}
