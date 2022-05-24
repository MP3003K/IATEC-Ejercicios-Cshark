
List<Pedido> pedidos = new()
{
   new Pedido(1,"A",Categoria.Cuna,1.75m,8),
   new Pedido(2,"B",Categoria.Cuna,4.99m,4),
   new Pedido(2,"C",Categoria.Cuna,2.78m,10),
   new Pedido(2,"D",Categoria.Primario,7.5m,3),
   new Pedido(2,"E",Categoria.Primario,2.3m,13),
   new Pedido(2,"F",Categoria.Primario,9.99m,20),
};


CalculadoraDePrecios calculadora = new();

foreach(var pedido in pedidos)
{
  pedido.ValorTotal=  calculadora.PrecioTotal(pedido);
}

foreach (var pedido in pedidos)
{
  /*  Console.WriteLine($"{pedido.ID}");
    Console.WriteLine($"{pedido.Producto}");
    Console.WriteLine($"{pedido.Categoria}");
    Console.WriteLine($"{pedido.PrecioUnitario}");
    Console.WriteLine($"{pedido.Descuento}");*/
    Console.WriteLine(pedido.ValorTotal);
    Console.WriteLine("------------------");
}
