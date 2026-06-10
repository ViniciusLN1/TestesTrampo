internal partial class Program12
{
    private static void Main12(string[] args)
    {
        //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        //ordem crescente ou decrescente.
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        if (b != 0 && a % b == 0 || a != 0 && b % a == 0)
        {
            Console.WriteLine("Sao multiplos");
        }
        else
        {
            Console.WriteLine("nao sao multiplos");
        }
    }
}   