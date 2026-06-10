internal partial class Program6
{
    private static void Main6(string[] args)
    {
     int a = int.Parse(Console.ReadLine());
     int b = int.Parse(Console.ReadLine());
     int c = int.Parse(Console.ReadLine());
     int d = int.Parse(Console.ReadLine());
    
     int calculo = (a * b)-(c * d);
     Console.WriteLine($"Diferença = {calculo}");
    }
}