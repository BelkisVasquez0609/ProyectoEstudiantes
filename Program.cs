using ProyectoEstudiantes;

var x = new Profesor();
var y = new Asignatura();
var asignatura = y.CrearAsignatura("IDS309", "Ingenieria Economica", 4);
x.CrearProfesor("123456789", "Samuel", "Charles", 20, asignatura, "Ingenieria");

Console.WriteLine(x.Cedula);