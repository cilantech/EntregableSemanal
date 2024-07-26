using EntregableSemanal.Models;




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

