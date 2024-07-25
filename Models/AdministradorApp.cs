using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public class AdministradorApp
{
    public List<Estudiante> Estudiantes { get; set; }
    public List<Profesor> Profesores { get; set; }

    public void AgregarEntregable(List<Estudiante> estudiantes)
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }

    public void AgregarProfesor(List<Profesor> Profesores)
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }

    public void MostrarEstudiantes()
    {
        Console.WriteLine("viendo detalles de ");
    }

    public void MostrarProfesores()
    {
        Console.WriteLine("viendo detalles de ");
    }
}
