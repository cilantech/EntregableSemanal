using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EntregableSemanal.Models;

public class Profesor
{
    public string? Asignatura { get; set; }
    public double Salario { get; set; }

    public DateOnly FechaContratacion { get; set; }
    public List<string>? Cursos { get; set; }


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

}
