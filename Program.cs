using EntregableSemanal.Models;

int opcion = 0;
bool salir = true;

do
{

    Console.WriteLine("╔═════════════════════════════╗");
    Console.WriteLine("║-----------------------------║");
    Console.WriteLine("║>   Gestor de App Don Riwi  <║");
    Console.WriteLine("║-----------------------------║");
    Console.WriteLine("╟─────────────────────────────╢");
    Console.WriteLine("║--[1]> Agregar producto   <--║");
    Console.WriteLine("║--[2]> Modificar producto <--║");
    Console.WriteLine("║--[3]> Eliminar producto  <--║");
    Console.WriteLine("║--[4]> Listar productos   <--║");
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







