internal partial class Program8
{
    private static void Main8(string[] args)
    {
        int codigoPeca1 = int.Parse(Console.ReadLine());
        int quantidadePeca1 = int.Parse(Console.ReadLine());
        double valorPeca1 = double.Parse(Console.ReadLine());

        int codigoPeca2 = int.Parse(Console.ReadLine());
        int quantidadePeca2 = int.Parse(Console.ReadLine());
        double valorPeca2 = double.Parse(Console.ReadLine());

        double calculo = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);
        Console.WriteLine($"Valor a ser pago = R${calculo:F2}");
    }
}