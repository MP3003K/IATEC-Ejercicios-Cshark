
    public class CalculadoraDePrecios
    {
    public decimal PrecioTotal(Pedido pedido)
    {
        decimal total;
        total = pedido.PrecioUnitario * pedido.Cantidad;
        if (pedido.Categoria == Categoria.Cuna)
        {
            if (total > 20.0m)
            {
                total = total * 0.8m;
            }
            else
            {
                total = total * 0.9m;
            }
        }
        else
        {
            Console.Write("Total: "+total+" -->"); 
            if (total > 30.0m)
            {
                total = total * 0.75m;
                Console.WriteLine(total);
            }
            else
            {
                total = total * 0.85m;
                Console.WriteLine(total);

            }
        }
        return total;
    }
}