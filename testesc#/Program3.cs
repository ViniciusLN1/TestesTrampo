internal class Program3{
    private static void Main3(string[] args)
    {
        //int num = int.Parse(Console.ReadLine());
        //char sexo = char.Parse(Console.ReadLine()); //char para um caracter, e varchar para varios caracteries
        //double num2 = double.Parse(Console.ReadLine());
        //Console.WriteLine($"Numero inteiro = {num}, sexo = {sexo} e caracter duplo = {num2}");

        //string[] vetor = Console.ReadLine().Split(" ");
        //string nome = vetor[0];
        //char sexualidade = char.Parse(vetor[1]);
        //int idade = int.Parse(vetor[2]);
        //double altura = double.Parse(vetor[3]);
        //Console.WriteLine($"nome = {nome}/ sexo = {sexualidade}/ idade = {idade}/ altura = {altura}/");

        //entrar com o nome completo
        string nome = Console.ReadLine();
        Console.WriteLine($"Nome = {nome}");

        //
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine($"Quantos = {nome}");

        //
        double preco = double.Parse(Console.ReadLine());

        //
        string[] tudo = Console.ReadLine().Split();

        Console.WriteLine($"Nome = {tudo[0]}, Idade = {int.Parse(tudo[1])}, Altura = {tudo[2]}");

    }
}