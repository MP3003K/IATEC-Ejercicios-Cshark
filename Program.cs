CalculadoraDePrecios calculadora = new();
List<Pedido> pedidos = new();

int opcion = 0, opcion2 = 0;
int ID = 1;
String productos = "";
int cantidad;
decimal precio;
Categoria categoria = Categoria.Cuna;
while (opcion != 2)
{
    Console.WriteLine("    Menu");
    Console.WriteLine("");
    Console.WriteLine(" 1. Agregar pedido");
    Console.WriteLine(" 2. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Write(" Ingrese Pedido :");
            productos = Console.ReadLine();
            Console.Write(" Precio         : ");
            precio = decimal.Parse(Console.ReadLine());
            Console.Write(" Cantidad       : ");
            cantidad = int.Parse(Console.ReadLine());

            while (opcion2 != 1 && opcion2 != 2)
            {
                Console.WriteLine("");
                Console.WriteLine(" Categoria ");
                Console.WriteLine("Elija una opcion");
                Console.WriteLine(" 1) Cuna");
                Console.WriteLine(" 2) Primarios");
                Console.WriteLine("");

                opcion2 = int.Parse(Console.ReadLine());
                switch (opcion2)
                {
                    case 1:
                        categoria = Categoria.Cuna;
                        break;
                    case 2:
                        categoria = Categoria.Primario;
                        break;
                    default:
                        Console.WriteLine("Elija una opcion correcta");
                        break;
                }
            }

            Pedido p = new Pedido(ID, productos, categoria, precio, cantidad);
            pedidos.Add(p);

            opcion2 = 0;
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Seleccione una opcion correcta");
            Console.WriteLine("");
            break;
    }
}

Console.WriteLine("");
Console.WriteLine("Lista de Pedidos");
Console.WriteLine("");

foreach (var pedido in pedidos)
{
    Console.WriteLine($"{pedido.ID}");
    Console.WriteLine($"{pedido.Producto}");
    Console.WriteLine($"{pedido.Categoria}");
    Console.WriteLine($"{pedido.PrecioUnitario}");
    Console.WriteLine($"{pedido.Descuento}");

    calculadora.PrecioTotal(pedido);
    Console.WriteLine(pedido.ValorTotal);
}

Console.WriteLine("Final de Lectura");


