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
        int opcion = 0;
        bool salir = true;

        do
        {
            Console.WriteLine("╔═════════════════════════════╗");
            Console.WriteLine("║-----------------------------║");
            Console.WriteLine("║>  Gestor de Escuela Riwi   <║");
            Console.WriteLine("║-----------------------------║");
            Console.WriteLine("╟─────────────────────────────╢");
            Console.WriteLine("║--[1]>      Agregar       <--║");
            Console.WriteLine("║--[2]>     Modificar      <--║");
            Console.WriteLine("║--[3]>      Eliminar      <--║");
            Console.WriteLine("║--[4]>       istar        <--║");
            Console.WriteLine("║--[5]------->Salir<----------║");
            Console.WriteLine("╚═════════════════════════════╝");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Has seleccionado la Opcion  1.");

                    AdministradorApp.Estudiantes.Add(new Estudiante("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Adolfo Putin", "10mo", new DateOnly(2000, 10, 05), new List<double> { 4.5, 3.8, 4.2 }));
                    AdministradorApp.Estudiantes.Add(new Estudiante("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Adolfo Putin", "10mo", new DateOnly(2005, 11, 19), new List<double> { 4.5, 3.8, 4.2 }));
                    AdministradorApp.Estudiantes.Add(new Estudiante("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Ana Hernández", "9no", new DateOnly(2002, 12, 20), new List<double> { 3.5, 3.7, 4.1 }));
                    AdministradorApp.Estudiantes.Add(new Estudiante("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Ana Hernández", "9no", new DateOnly(2002, 10, 20), new List<double> { 3.5, 3.7, 4.1 }));

                    Console.WriteLine($" los datos del estudiante son:");

                    AdministradorApp.MostrarEstudiantes();




                    // foreach (var estudiante in AdministradorApp.Estudiantes)
                    // {
                    //     Console.WriteLine(estudiante.Nombre);
                    // }

                    Console.Write("");

                    Console.Clear();
                    Console.WriteLine("");

                    break;

                case 2:
                    Console.Clear();

                    break;
                case 3:


                    break;
                case 4:
                    Console.Clear();

                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Cerrando gestor inventario programa.");
                    Thread.Sleep(2000);
                    salir = true;
                    break;
                default:
                    Console.WriteLine("*ERROR* Opcion  no válida. Inténtalo de nuevo.");
                    break;
            }

        } while (!salir);
    }


}
