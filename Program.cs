Console.WriteLine("Hello, World!");
List<Estudiante> estudiantes = new()
{
new Estudiante(1,"Liza"),
new Estudiante(2,"Ana"),
new Estudiante(3,"Juana"),
new Estudiante(4,"Zeno"),
new Estudiante(4,"Perez"),
};

//Por fin 55

var ordenadosPorNombre = estudiantes.OrderBy(e => e.Nombre);
foreach( var estudiante in ordenadosPorNombre)
{
    Console.WriteLine($"{estudiante.ID}{estudiante.Nombre}");
}