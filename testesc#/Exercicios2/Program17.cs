internal partial class Program17
{
    private static void Main17(string[] args)
    {
        double salario = double.Parse(Console.ReadLine());
        double imposto = 0;

        if (salario <= 2000)
        {
            Console.WriteLine("Isento");
            return;
        }

        if (salario > 2000)
            imposto += (Math.Min(salario, 3000) - 2000) * 0.08;

        if (salario > 3000)
            imposto += (Math.Min(salario, 4500) - 3000) * 0.18;

        if (salario > 4500)
            imposto += (salario - 4500) * 0.28;

        Console.WriteLine($"R$ {imposto:F2}");
    }
}
