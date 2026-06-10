internal partial class Program5
{
    private static void Main5(string[] args)
    {
       double raio = double.Parse(Console.ReadLine());
       double calculo = raio * raio * 3.14159;
       Console.WriteLine($"Área do circulo = {calculo:f4}");
    }
}