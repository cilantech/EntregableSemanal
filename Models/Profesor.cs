using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EntregableSemanal.Models;

public class Profesor : Persona
{
    public string? Asignatura { get; set; }
    public double Salario { get; set; }

    public DateOnly FechaContratacion { get; set; }
    public List<string>? Cursos { get; set; }


    public Profesor(string nombre,string apellido,string tipoDocumento, int numeroDocumento,string email,string telefono,string asignatura, double salario,DateOnly fechaContratacion,List<string> cursos): base(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono)
    {
        Asignatura = asignatura;
        Salario = Salario;
        FechaContratacion = fechaContratacion;
        Cursos = cursos;
    }


    public int CalcularAntiguedad()
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);

        int year = 5;

        return year;
    }

    public void CalcularSalario()
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }
    //metodo toString
    public override string ToString()
    {
        return $"Profesor: {Nombre} {Apellido} - Documento: {NumeroDocumento} - Email: {Email} - Telefono: {Telefono} - Asignatura: {Asignatura} - Salario: {Salario} - Fecha Contratación: {FechaContratacion:dd/MM/yyyy} - Cursos: {string.Join(", ", Cursos)}";
    }

}
