﻿
public enum Categoria
{
    Cuna = 0,
    Primario = 1
}
public class Pedido
{
    public int ID { get; private set; }
    public String Producto { get; private set; }
    public Categoria Categoria { get; private set; }

    public decimal PrecioUnitario { get; private set; }

    public int Cantidad { get; private set; }

    public decimal Descuento { get; private set; }

    public decimal temp_total = 0m;
    public decimal ValorTotal { get => CalcularTotal(); set => temp_total = value; }

    public decimal CalcularTotal()
    {
        Console.WriteLine("Ejecutando Funcion CalcularTotal");
        temp_total = (PrecioUnitario * Cantidad);
        return temp_total;
    }

    public Pedido(int id, string producto, Categoria categoria, decimal precioUnitario, int cantidad)
    {
        ID = id;
        Producto = producto;
        Categoria = categoria;
        PrecioUnitario = precioUnitario;
        Cantidad = cantidad;
    }
}