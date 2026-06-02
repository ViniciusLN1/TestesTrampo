byte n1 = 126;
int n2 = 1000;
int n3 = 2147483647;
long n4 = 2147483648L;
bool completo = false;
char genero = 'F'; //char usa aspas simples
char letra = '\u0041';
double n6 = 4.5;
float n7 = 4.55f;
string nome = "Maria"; //string é aspas duplas
object obj1 = "Alex Brown";
object obj2 = 4.5f;

Console.WriteLine(completo);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(genero);
Console.WriteLine(letra);
Console.WriteLine(n6);
Console.WriteLine(n7);
Console.WriteLine(nome);
Console.WriteLine(obj1);
Console.WriteLine(obj2);

int n8 = int.MinValue;
Console.WriteLine(n8);

int n9 = int.MaxValue;
Console.WriteLine(n9);

sbyte n10 = sbyte.MinValue;
Console.WriteLine(n10);

decimal n11=    decimal.MaxValue;
Console.WriteLine(n11);

Console.Write("teste 2");
Console.WriteLine("teste 1");


// OPERADORES DE ATRIBUIÇÃO:
//  = 
// += 
// -= 
// *= 
// /= 
// %= 
// EXEMPLOS: 

int a = 10;
Console.WriteLine(a);

a += 2;
Console.WriteLine(a);

a *= 2;
Console.WriteLine(a);
Console.WriteLine(a);

string s = "ABC";
Console.WriteLine(s);

s += "DEF";
Console.WriteLine(s);

// ++ ADICIONA 1 / A++ / ++A 
// -- DIMINUI 1 / A-- / --A
//EXEMPLOS:

int b = 10;
Console.WriteLine(b);
b ++;
Console.WriteLine(b);

int c = 10;
Console.WriteLine(c);
c --;
Console.WriteLine(c);

float x = 4.5f;
double y = x;

Console.WriteLine(y); //Deu certo



//namespace curso
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a;
//            float b;
//
//            a = 5.1;    
//            //b = a; //Não deu certo, tem que ser explicito ~~ b = (float)a;
//        }
//    }
//}

//namespace ex1 {
//    class Program{
//        static void Main(string[] args)
//        {
//            int a = 5;
//            int b = 2;
//
//            double resultado = a / b;
//            Console.WriteLine(resultado);
//       }
//    }
//}

string algo = Console.ReadLine();
Console.WriteLine("Voce digitou: " + algo);