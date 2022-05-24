public class Numeros
{
  
    public int ID { get; private set; }
    public int Numero { get; private set; }

    public Numeros(int iD, int numero)
    {
        ID = iD;
        Numero = numero;
    }
}