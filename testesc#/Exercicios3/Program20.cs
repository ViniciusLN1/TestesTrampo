internal partial class Program20
{
    private static void Main20(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        while (x != 0 && y != 0)
        {
            if(x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quarto");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro");
            }
            else
            {
                Console.WriteLine("Segundo");
            }
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }
    }
       
}
