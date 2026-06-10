internal partial class Program19
{
    private static void Main19(string[] args)
    {
        int senha = 2002;

        int senhaDigitada = int.Parse(Console.ReadLine());
        while (senhaDigitada != senha)
        {
            if (senhaDigitada != senha)
            {
                Console.WriteLine("SENHA INVALIDA!");
            }
            senhaDigitada = int.Parse(Console.ReadLine());  

        }

        Console.WriteLine("ACESSOO PERMITIDO!");
    }   
}
