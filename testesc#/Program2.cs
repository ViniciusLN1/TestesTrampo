internal class Program2
{
    private static void Main2(string[] args)
    {
        string frase = Console.ReadLine();

        Console.WriteLine("voce digitou: " + frase);
        string s = Console.ReadLine();
        string[] vet = s.Split(' ');
        string p1 = vet[0];
        string p2 = vet[1];
        string p3 = vet[2];
        Console.WriteLine("Voce digitou: "+ p1 + p2);
        Console.WriteLine(p3);
        String[] vet2 = Console.ReadLine().Split(' ');
        string p4 = vet2[0];
        string p5 = vet2[1];
        string p6 = vet2[2];
        Console.WriteLine($"Voce digitou: 1{p4} 2{p5} 3{p6}");
    }

}