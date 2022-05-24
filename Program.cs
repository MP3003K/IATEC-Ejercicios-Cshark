int n, num, mayor = 0;

Console.WriteLine("¿De cuantos números?");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());
    if (num > mayor)
    {
        mayor = num;
    }
}

Console.WriteLine($"El mayor es: {mayor}");
//Console.ReadKey(); *2
