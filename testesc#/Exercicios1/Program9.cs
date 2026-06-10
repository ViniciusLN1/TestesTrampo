internal partial class Program9
{
    private static void Main9(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double areaTriangulo = (a * c) / 2;
        double areaCirculo = 3.14159 * (c * c ); 
        double areaTrapezio = ((a + b) * c) / 2;
        double areaQuadrado = b * b;
        double areaRetangulo = a * b;

        Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}, CIRCULO: {areaCirculo:F3}, TRAPEZIO: {areaTrapezio:F3}, QUADRADO: {areaQuadrado:F3}, RETANGULO: {areaRetangulo:F3}");
    }
}