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

    public Estudiante(string nombre, string apellido, string tipoDocumento, int numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNaciemiento, List<double> calificaciones) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
        NombreAcudiente = nombreAcudiente;
        CursoActual = cursoActual;
        FechaNaciemiento = fechaNaciemiento;
        Calificaciones = calificaciones;
    }


    public override string ToString()
    {
        return $"Estudiante:{Id} {Nombre} {Apellido}, Documento: {TipoDocumento} {NumeroDocumento}, Email: {Email}, Telefono: {Telefono}, Nombre Acudiente: {NombreAcudiente}, Curso Actual: {CursoActual}, Fecha Nacimiento: {FechaNaciemiento.ToShortDateString()}";
    }

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

    }


    public int CalcularEdad()
    {
        int year = DateTime.Now.Year - FechaNaciemiento.Year;
        return year;
    }


    public virtual void MostrarDetalles()
    {

        base.MostrarDetalles();
        Console.WriteLine($"Nombre del Acudiente: {NombreAcudiente}");
        Console.WriteLine($"Curso Actual: {CursoActual}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNaciemiento}");
        Console.WriteLine($"Calificaciones: {Calificaciones}");



        Thread.Sleep(2000);
    }




}
