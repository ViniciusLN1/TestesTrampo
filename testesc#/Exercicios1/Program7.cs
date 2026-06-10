internal partial class Program7
{
    private static void Main7(string[] args)
    {
     int numero = int.Parse(Console.ReadLine());
     int horas = int.Parse(Console.ReadLine());
     double valorhora = double.Parse(Console.ReadLine());
     double salario = (horas * valorhora);

     Console.WriteLine($"Numero = {numero}, Salario = {salario:F2}");
    }
}