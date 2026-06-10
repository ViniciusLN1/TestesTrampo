internal partial class Program14
{
    private static void Main14(string[] args)
    {
        int codigo = int.Parse(Console.ReadLine());
        double quantidade = double.Parse(Console.ReadLine());

        double preco = 0;

        if(codigo == 1)
        {
            preco = 4.00;
        }
        else if (codigo == 2)
        {
            preco = 4.50;
        }
        else if (codigo == 3)
        {
            preco = 5.00;
        }

        else if(codigo == 4)
        {
            preco = 2.00;
        }
        else if(codigo == 5)
        {
            preco = 1.50;

        }

        double calculo = quantidade * preco;

        Console.WriteLine($"Total: R${calculo:F2}");
    }
}   