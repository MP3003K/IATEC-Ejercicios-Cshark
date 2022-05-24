
    public class CalculadoraDePrecios
    {
        public void PrecioTotal()
        {
        List<Pedido> pedidos = new();
        foreach( var pedido in pedidos)
        {
            if (pedido.Categoria == 0)
            {
                pedido.ValorTotal = 1m;
            }
            else
            {
                pedido.ValorTotal =0m;
            }
        }

    }
        
    }