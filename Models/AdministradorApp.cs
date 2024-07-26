using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public static class AdministradorApp
{
    public static List<Estudiante>? Estudiantes { get; set; } = new List<Estudiante>();
    public static List<Profesor>? Profesores { get; set; } = new List<Profesor>();

    public static void AgregarEstudiantes(List<Estudiante> estudiantes)
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }

    public static void AgregarProfesor(List<Profesor> Profesores)
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }

    public static void MostrarEstudiantes()
    {

        
        Console.WriteLine("viendo detalles de ");

        foreach (var estudiante in Estudiantes)
        {

            estudiante.MostrarDetalles();
            // Console.WriteLine(estudiante.ToString());
        }
    }

    public static void MostrarProfesores()
    {
        Console.WriteLine("viendo detalles de ");
    }

    public static void MostrarMenu()
    {
        Console.WriteLine("viendo detalles de ");
    }

  
}
