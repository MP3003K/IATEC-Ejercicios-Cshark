
List<Pedido> pedidos = new()
{
   new Pedido(1,"Revista.g34",Categoria.Cuna,0.98m,2),
   new Pedido(2,"cuadernillo.g25",Categoria.Cuna,5.28m,9),
   new Pedido(2,"Corbata.g45",Categoria.Primario,9.80m,5),
   new Pedido(2,"Buso.g12",Categoria.Primario,20.99m,2)
};
/*
foreach (var pedido in pedidos)
{
    Console.WriteLine($"{pedido.ID}");
    Console.WriteLine($"{pedido.Producto}");
    Console.WriteLine($"{pedido.Categoria}");
    Console.WriteLine($"{pedido.PrecioUnitario}");
    Console.WriteLine($"{pedido.Descuento}");
}
*/


foreach (var pedido in pedidos)
{
    Console.WriteLine($"{pedido.ID}");
    Console.WriteLine($"{pedido.Producto}");
    Console.WriteLine($"{pedido.Categoria}");
    Console.WriteLine($"{pedido.PrecioUnitario}");
    Console.WriteLine($"{pedido.Descuento}");
    Console.WriteLine(pedido.ValorTotal);
    Console.WriteLine("------------------");
}