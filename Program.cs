using Quadrado01;
using Circulo01;

internal class Program
{
    private static void Main(string[] args)
    {
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Área do circulo: " + circulo.CalcularArea());

        Quadrado quadrado = new Quadrado(4);
        Console.WriteLine("Área do quadrado: " + quadrado.CalcularArea());
    }
}