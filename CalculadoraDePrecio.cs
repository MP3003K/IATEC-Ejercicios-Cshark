
public class CalculadoraDePrecios
{
    public void PrecioTotal(Pedido pedido)
    {
        decimal total, descuento;

        total = pedido.PrecioUnitario * pedido.Cantidad;

        if (pedido.Categoria == Categoria.Cuna)
        {
            if (total > 20.0m)
            {
                descuento = total * 0.2m;
            }
            else
            {
                descuento = total * 0.1m;
            }
        }
        else
        {
            if (total > 30.0m)
            {
                descuento = total * 0.25m;
            }
            else
            {
                descuento = total * 0.15m;

            }
        }
        total = total - descuento;
        pedido.ValorTotal = total;
        pedido.Descuento = descuento;
    }
}