using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public class Estudiante
{
    public string NombreAcudiente { get; set; }
    public string CursoActual { get; set; }
    public DateOnly FechaNaciemiento { get; set; }
    public List<double> Calificaciones { get; set; }



    public Estudiante(string nombreAcudiente, string cursoActual, DateOnly fechaNaciemiento, List<double> calificaciones)
    {
        NombreAcudiente = nombreAcudiente;
        CursoActual = cursoActual;
        FechaNaciemiento = fechaNaciemiento;
        Calificaciones = calificaciones;
    }

    public void AgregarNotas(double calificacion)
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
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


}
