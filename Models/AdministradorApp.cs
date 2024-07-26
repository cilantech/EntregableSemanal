using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableSemanal.Models;

public static class AdministradorApp
{
    public static List<Estudiante>? Estudiantes { get; set; } = new List<Estudiante>();
    public static List<Profesor>? Profesores { get; set; } = new List<Profesor>();

    public static void AgregarEstudiantes(Estudiante estudiante)
    {

    }

    public static void AgregarProfesor(List<Profesor> Profesores)
    {
        // var nota = new List<calificacion>(4500.35);

        // Calificaciones.Add(nota);
    }

    public static void MostrarEstudiantes()
    {

        foreach (var estudiante in Estudiantes)
        {

            estudiante.MostrarDetalles();
            // Console.WriteLine(estudiante.ToString());
        }
    }

    public static void MostrarProfesores()
    {
        Console.WriteLine("viendo detalles de ");
        foreach (var profesor in Profesores)
        {
            profesor.MostrarDetalles();

        }
    }

    public static void MostrarMenu()
    {
        int opcionTipoUsuario;
        bool salirTipoUsuario = true;

        int opcionEstudiante;
        bool salirEstudiante = true;

        int opcionProfesores;
        bool salirProfesores = true;

        int opcionConsulta;
        bool salirConsulta = true;
        do
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════╗");
            Console.WriteLine("║-----------------------------║");
            Console.WriteLine("║>    Gestor Escuela Riwi    <║");
            Console.WriteLine("║-----------------------------║");
            Console.WriteLine("╟─────────────────────────────╢");
            Console.WriteLine("║[1]-->    Estudiantes     <--║");
            Console.WriteLine("║[2]-->    Profesores      <--║");
            Console.WriteLine("║[3]-->    Salir           <--║");
            Console.WriteLine("╚═════════════════════════════╝");
            Console.Write("Seleccione que tipo de usuario quiere gestionar: ");
            opcionTipoUsuario = int.Parse(Console.ReadLine());

            switch (opcionTipoUsuario)
            {
                case 1:
                    Console.WriteLine("Estudiantes");
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("╔═════════════════════════════╗");
                        Console.WriteLine("║-----------------------------║");
                        Console.WriteLine("║>  Gestor Estudiantes Riwi  <║");
                        Console.WriteLine("║-----------------------------║");
                        Console.WriteLine("╟─────────────────────────────╢");
                        Console.WriteLine("║--[1]-->    Agregar       <--║");
                        Console.WriteLine("║--[2]-->    Editar        <--║");
                        Console.WriteLine("║--[3]-->    Eliminar      <--║");
                        Console.WriteLine("║--[4]-->    Ver datos     <--║");
                        Console.WriteLine("║--[5]-->    Consultar     <--║");
                        Console.WriteLine("║--[6]-->    Salir         <--║");
                        Console.WriteLine("╚═════════════════════════════╝");
                        Console.Write("Seleccione una opción: ");

                        opcionEstudiante = int.Parse(Console.ReadLine());

                        switch (opcionEstudiante)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Estudiantes Riwi  <║");
                                Console.WriteLine("║-------- + AGREGAR + --------║");
                                Console.WriteLine("═══════════════════════════════");

                                Estudiantes.Add(new Estudiante("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Adolfo Putin", "10mo", new DateOnly(2000, 10, 05), new List<double> { 4.5, 3.8, 4.2 }));
                                Estudiantes.Add(new Estudiante("Patricia", "ortiz", "CC", 45345345, "dfgfgd@gmail", "310465254", "Adolfo Putin", "11mo", new DateOnly(2005, 11, 19), new List<double> { 4.5, 3.8, 4.2 }));
                                Estudiantes.Add(new Estudiante("Lina", "Martinez", "TI", 45345345, "dfgdf@example.com", "3201234567", "Putin Hernández", "9no", new DateOnly(2002, 12, 20), new List<double> { 3.5, 3.7, 4.1 }));
                                Estudiantes.Add(new Estudiante("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Ana Hernández", "8no", new DateOnly(2002, 10, 20), new List<double> { 3.5, 3.7, 4.1 }));
                                Estudiantes.Add(new Estudiante("Leonardo", "Rocha", "TI", 1010114525, "l@example.com", "32046558548", "lopies Hernández", "9no", new DateOnly(2002, 10, 20), new List<double> { 3.5, 3.7, 4.1 }));

                                Console.Write("Ingrese Nombre: ");
                                string NuevoEstudianteNombre = Console.ReadLine();

                                Console.Write("Apellido del Estudiante: ");
                                string NuevoEstudianteApellido = Console.ReadLine();

                                Console.Write("Tipo Documento del Estudiante: ");
                                string NuevoEstudianteTipoDocumento = Console.ReadLine();

                                Console.Write("Documento del Estudiante: ");
                                int NuevoEstudianteDocumento = int.Parse(Console.ReadLine());

                                Console.Write("Email del Estudiante: ");
                                string NuevoEstudianteEmail = Console.ReadLine();

                                Console.Write("Telefono del Estudiante: ");
                                String NuevoEstudianteTelefono = Console.ReadLine();

                                Console.Write("Nombre Acudiente del Estudiante: ");
                                string NuevoEstudianteAcudiente = Console.ReadLine();

                                Console.Write("Nombre Curso Actual del Estudiante: ");
                                string NuevoEstudianteCurso = Console.ReadLine();

                                Console.Write("Fecha de Nacimiento del Estudiante (YYYY-MM-DD): ");
                                DateOnly NuevoEstudianteFechaNacimiento = DateOnly.Parse(Console.ReadLine());

                                Console.Write("Notas del Estudiante:");
                                int NuevoEstudianteNotas = int.Parse(Console.ReadLine());

                                Estudiantes.Add(new Estudiante(NuevoEstudianteNombre, NuevoEstudianteApellido, NuevoEstudianteTipoDocumento, NuevoEstudianteDocumento, NuevoEstudianteEmail, NuevoEstudianteTelefono, NuevoEstudianteAcudiente, NuevoEstudianteCurso, NuevoEstudianteFechaNacimiento, new List<double> { NuevoEstudianteNotas }));

                                Console.WriteLine($" los datos del estudiantes son:");

                                MostrarEstudiantes();

                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Estudiantes Riwi  <║");
                                Console.WriteLine("║--------- + EDITAR + --------║");
                                Console.WriteLine("═══════════════════════════════");

                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Estudiantes Riwi  <║");
                                Console.WriteLine("║-------- + ELIMINAR + -------║");
                                Console.WriteLine("═══════════════════════════════");


                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Estudiantes Riwi  <║");
                                Console.WriteLine("║------ -- + MOSTRAR + -------║");
                                Console.WriteLine("═══════════════════════════════");

                                MostrarEstudiantes();

                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("║------------------------------------------------------------------------------------------║");
                                Console.WriteLine("║>                                     Gestor Riwi                                        <║");
                                Console.WriteLine("║------------------------------------- + CONSULTA + ---------------------------------------║");
                                Console.WriteLine("║--[1]-->       Encontrar aquellos con un promedio de calificaciones superior a 85      <--║");
                                Console.WriteLine("║--[2]-->             Obtener la lista de profesores que enseñan más de un curso        <--║");
                                Console.WriteLine("║--[3]-->  Filtrar estudiantes para obtener solo aquellos cuya edad sea mayor a 16 años <--║");
                                Console.WriteLine("║--[4]-->   Obtener la lista de estudiantes ordenada por apellido en orden ascendente   <--║");
                                Console.WriteLine("║--[5]-->             Calcular el salario total de todos los profesores                 <--║");
                                Console.WriteLine("║--[6]-->                                  Salir                                        <--║");
                                Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════");

                                Console.Write("Seleccione una opción: ");
                                opcionConsulta = int.Parse(Console.ReadLine());

                                switch (opcionConsulta)
                                {
                                    case 1:

                                        var estudiantesConBuenPromedio = Estudiantes.Where(estudiante => estudiante.Calificaciones.Average() > 85).ToList();
                                        Console.WriteLine(estudiantesConBuenPromedio);
                                        break;
                                    case 2:

                                        // var profesoresConMasDeUnCurso = Cursos.GroupBy(curso => curso.Profesor).Where(grupo => grupo.Count() > 1).Select(grupo => grupo.Key).ToList();



                                        break;
                                    case 3:


                                        break;
                                    case 4:


                                        break;
                                    case 5:


                                        break;
                                    case 6:
                                        salirConsulta = true;


                                        break;
                                    default:
                                        Console.WriteLine("*ERROR* Opcion  no válida. Inténtalo de nuevo.");
                                        break;
                                }



                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>    Cerrando Gestor Riwi   <║");
                                Console.WriteLine("║-------- + SALIENDO + -------║");
                                Console.WriteLine("═══════════════════════════════");
                                Console.Clear();
                                Thread.Sleep(2000);
                                salirEstudiante = true;
                                break;
                            default:
                                Console.WriteLine("*ERROR* Opcion  no válida. Inténtalo de nuevo.");
                                break;
                        }

                    } while (!salirEstudiante);

                    break;

                case 2:

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("╔═════════════════════════════╗");
                        Console.WriteLine("║-----------------------------║");
                        Console.WriteLine("║>   Gestor Profesores Riwi  <║");
                        Console.WriteLine("║-----------------------------║");
                        Console.WriteLine("╟─────────────────────────────╢");
                        Console.WriteLine("║--[1]-->    Agregar       <--║");
                        Console.WriteLine("║--[2]-->    Editar        <--║");
                        Console.WriteLine("║--[3]-->    Eliminar      <--║");
                        Console.WriteLine("║--[4]-->    Ver datos     <--║");
                        Console.WriteLine("║--[4]-->    Consultar     <--║");
                        Console.WriteLine("║--[5]-->    Salir         <--║");
                        Console.WriteLine("╚═════════════════════════════╝");
                        Console.Write("Seleccione una opción: ");

                        opcionProfesores = int.Parse(Console.ReadLine());

                        switch (opcionProfesores)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Profesores  Riwi  <║");
                                Console.WriteLine("║-------- + AGREGAR + --------║");
                                Console.WriteLine("═══════════════════════════════");

                                Profesores.Add(new Profesor("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Fisica", 2200.36, new DateOnly(2012, 10, 05), new List<string> { "Septimos" }));
                                Profesores.Add(new Profesor("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Matematicas", 2500.56, new DateOnly(2005, 11, 19), new List<string> { "Primaria" }));
                                Profesores.Add(new Profesor("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Lengua", 1900.62, new DateOnly(2009, 12, 20), new List<string> { "Noveno" }));
                                Profesores.Add(new Profesor("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Musica", 1100.65, new DateOnly(2003, 10, 20), new List<string> { "Once" }));

                                Console.Write("Ingrese Nombre Profesores: ");
                                string NuevoProfesorNombre = Console.ReadLine();

                                Console.Write("Apellido del Profesores: ");
                                string NuevoProfesorApellido = Console.ReadLine();

                                Console.Write("Tipo Documento del Profesores: ");
                                string NuevoProfesorTipoDocumento = Console.ReadLine();

                                Console.Write("Documento del Profesores: ");
                                int NuevoProfesorDocumento = int.Parse(Console.ReadLine());

                                Console.Write("Email del Profesores: ");
                                string NuevoProfesorEmail = Console.ReadLine();

                                Console.Write("Telefono del Profesores: ");
                                int NuevoProfesorTelefono = int.Parse(Console.ReadLine());

                                Console.Write("Salario del Profesores: ");
                                double NuevoProfesorSalario = double.Parse(Console.ReadLine());

                                Console.Write("Nombre Curso Actual del Profesores: ");
                                string NuevoProfesorCurso = Console.ReadLine();

                                Console.Write("Fecha de Contratacion del Profesores (DD/MM/YYYY): ");
                                DateOnly NuevoProfesorFechaContratacion = DateOnly.Parse(Console.ReadLine());

                                Console.Write("Cursos del Profesores:");
                                string NuevoProfesorNotas = Console.ReadLine();

                                Console.WriteLine($" los datos del Profesores son:");

                                MostrarProfesores();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Profesores  Riwi  <║");
                                Console.WriteLine("║--------- + EDITAR + --------║");
                                Console.WriteLine("═══════════════════════════════");

                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("╔═════════════════════════════╗");
                                Console.WriteLine("║-----------------------------║");
                                Console.WriteLine("║>  Gestor Profesores  Riwi  <║");
                                Console.WriteLine("║-------- + ELIMINAR + -------║");
                                Console.WriteLine("═══════════════════════════════");
                                break;
                            case 4:

                                MostrarProfesores();

                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Cerrando gestor Profesores.");
                                Thread.Sleep(2000);
                                salirProfesores = true;
                                break;
                            default:
                                Console.WriteLine("*ERROR* Opcion  no válida. Inténtalo de nuevo.");
                                break;
                        }

                    } while (!salirProfesores);

                    break;
                default:
                    Console.WriteLine("*ERROR* Opcion  no válida. Inténtalo de nuevo.");
                    break;
            }

        } while (!salirTipoUsuario);




        // do
        // {
        //     Console.Clear();
        //     Console.WriteLine("╔═════════════════════════════╗");
        //     Console.WriteLine("║-----------------------------║");
        //     Console.WriteLine("║>    Gestor Escuela Riwi    <║");
        //     Console.WriteLine("║-----------------------------║");
        //     Console.WriteLine("╟─────────────────────────────╢");
        //     Console.WriteLine("║--[1]-->    Agregar       <--║");
        //     Console.WriteLine("║--[2]-->    Editar        <--║");
        //     Console.WriteLine("║--[3]-->    Eliminar      <--║");
        //     Console.WriteLine("║--[4]-->    Ver datos     <--║");
        //     Console.WriteLine("║--[4]-->    Consultar     <--║");
        //     Console.WriteLine("║--[5]-->    Salir         <--║");
        //     Console.WriteLine("╚═════════════════════════════╝");
        //     Console.Write("Seleccione una opción: ");

        //     opcion = int.Parse(Console.ReadLine());

        //     switch (opcion)
        //     {
        //         case 1:
        //             Console.Clear();

        //             Console.WriteLine("Has seleccionado la Opcion  1.");

        //             Estudiantes.Add(new Estudiante("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Adolfo Putin", "10mo", new DateOnly(2000, 10, 05), new List<double> { 4.5, 3.8, 4.2 }));
        //             Estudiantes.Add(new Estudiante("pepe", "ruiz", "CC", 101011771, "pepito@gmail", "310465254", "Adolfo Putin", "10mo", new DateOnly(2005, 11, 19), new List<double> { 4.5, 3.8, 4.2 }));
        //             Estudiantes.Add(new Estudiante("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Ana Hernández", "9no", new DateOnly(2002, 12, 20), new List<double> { 3.5, 3.7, 4.1 }));
        //             Estudiantes.Add(new Estudiante("Luis", "Hernández", "TI", 303030303, "luis@example.com", "3201234567", "Ana Hernández", "9no", new DateOnly(2002, 10, 20), new List<double> { 3.5, 3.7, 4.1 }));

        //             Console.Write("Ingrese Nombre: ");
        //             string NuevoEstudianteNombre = Console.ReadLine();

        //             Console.Write("Apellido del Estudiante: ");
        //             string NuevoEstudianteApellido = Console.ReadLine();

        //             Console.Write("Tipo Documento del Estudiante: ");
        //             string NuevoEstudianteTipoDocumento = Console.ReadLine();

        //             Console.Write("Documento del Estudiante: ");
        //             int NuevoEstudianteDocumento = int.Parse(Console.ReadLine());

        //             Console.Write("Email del Estudiante: ");
        //             string NuevoEstudianteEmail = Console.ReadLine();

        //             Console.Write("Telefono del Estudiante: ");
        //             int NuevoEstudianteTelefono = int.Parse(Console.ReadLine());

        //             Console.Write("Nombre Acudiente del Estudiante: ");
        //             string NuevoEstudianteAcudiente = Console.ReadLine();

        //             Console.Write("Nombre Curso Actual del Estudiante: ");
        //             string NuevoEstudianteCurso = Console.ReadLine();

        //             Console.Write("Fecha de Nacimiento del Estudiante (DD/MM/YYYY): ");
        //             DateOnly NuevoEstudianteFechaNacimiento = DateOnly.Parse(Console.ReadLine());

        //             Console.Write("Notas del Estudiante:");
        //             int NuevoEstudianteNotas = int.Parse(Console.ReadLine());



        //             Console.WriteLine($" los datos del estudiante son:");

        //             MostrarEstudiantes();




        //             foreach (var estudiante in AdministradorApp.Estudiantes)
        //             {
        //                 Console.WriteLine(estudiante.Nombre);
        //             }

        //             Console.Write("");

        //             Console.Clear();
        //             Console.WriteLine("");

        //             break;

        //         case 2:
        //             Console.Clear();

        //             break;
        //         case 3:


        //             break;
        //         case 4:

        //             MostrarEstudiantes();

        //             break;
        //         case 5:
        //             Console.Clear();
        //             Console.WriteLine("Cerrando gestor inventario programa.");
        //             Thread.Sleep(2000);
        //             salir = true;
        //             break;
        //         default:
        //             Console.WriteLine("*ERROR* Opcion  no válida. Inténtalo de nuevo.");
        //             break;
        //     }

        // } while (!salir);
    }


}
