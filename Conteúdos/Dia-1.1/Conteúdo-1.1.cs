// Conhecendo os tipos de C#

// Tipos de Linguagens
int x;
decimal y;
bool z;

// Nomenclatura de variáveis
int numberOfOrdersInOctober;
int numberOfOrdersInNovember;
int numberOfOrdersInDecember;

// Interfaces de comunicação com o programa
//Entrada de Dados
int Age = int.Parse(Console.ReadLine());
decimal Average = decimal.Parse(Console.ReadLine());
bool Permission = bool.Parse(Console.ReadLine());
string Name = Console.ReadLine();

//Entrada de Dados
int Age = int.Parse(Console.ReadLine());
decimal Average = decimal.Parse(Console.ReadLine());
bool Permission = bool.Parse(Console.ReadLine());
string Name = Console.ReadLine();

//Exemplo de concatenação de Dados
int Number = 10;
string Name = "Trybe";
Console.WriteLine("O valor da variável numero é: " + Number);
Console.WriteLine("Eu sou um estudante " + Name + "!");

// Outros Tipos de Dados do C#]
// Criando um enum
enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};
//Utilizando um enum
CardinalPoints direction = CardinalPoints.Norte;
Console.WriteLine("Ponto Cardeal: " + direction);

// Outros tipos de dados que representam números inteiros

// Para termos um controle mais preciso, podemos utilizar tipos signed, que permitem o armazenamento de valores negativos, e os unsigned, cujos valores podem ser somente o 0 e valores positivos.

// Constantes
//Como declarar uma constante
const string url = "https://www.betrybe.com/";
const int numberOfAttemptsAllowed = 5;

// Variáveis com tipo implícito
//esta variável será compilada como string
var school = "Trybe";

//esta variável será compilada como int
var semester = 1;

//esta variável será compilada como um tipo anônimo
var student = new { name = "Jorge", age = 30 };

Console.WriteLine("Olá! Me chamo " + student.name + " " +
                  "sou um estudante da escola " + school + " " +
                  "estou no " + semester + "º semestre " +
                  "e tenho " + student.age + " anos");


// Operações Aritméticas
//Adição
int a = 50, b = 50;
int result1 = a + b;
Console.WriteLine(a + " + " + b + " = " + result1);

//Subtração
int c = 77, d = 21;
int result2 = c - d;
Console.WriteLine(c + " - " + d + " = " + result2);

//Multiplicação
int e = 5, f = 5;
int result3 = e * f;
Console.WriteLine(e + " * " + f + " = " + result3);

//divisão
int g = 90, h = 9;
int result4 = g / h;
Console.WriteLine(g + " / " + h + " = " + result4);

//módulo
int i = 36, j = 7;
int result5 = i % j;
Console.WriteLine("O resto da divisão de " + i + " por " + j + " é " + result5);

// Ordem das expressões
//ordem de execução
int a = 5, b = 10, c = 15;
int result1 = (a + b * c);
Console.WriteLine("(" + a + " + " + b + " * " + c + ") = " + result1);

//utilizando parênteses
int result2 = ((a + b) * c);
Console.WriteLine("((" + a + " + " + b + ") * " + c + ") = " + result2);

// Operadores Aritméticos de Atribuição reduzida
int a = 1;
//incrementa + 1 ao valor de a
a++; //substitui a instrução a = a + 1 
Console.WriteLine("A = " + a);

int b = 10;
//decrementa o -1 ao valor b
b--; //substitui a instrução b = b - 1
Console.WriteLine("B = " + b);

//incrementa qualquer valor à direita na variável à esquerda
int c = 23;
c += 15; //substitui a instrução c = c + 15 
Console.WriteLine("C = " + c);

//incrementa multiplicando qualquer valor à direita na variável à esquerda
int e = 11;
e *= 3; //substitui a instrução e = e * 3 
Console.WriteLine("E = " + e);

//decrementa dividindo qualquer valor à direita na variável à esquerda
decimal f = 11;
f /= 3; //substitui a instrução f = f / 3 
Console.WriteLine("F = " + f.ToString("N2"));

//decrementa com a operação de módulo de qualquer valor à direita na variável à esquerda
decimal g = 11;
g %= 3; //substitui a instrução g = g % 3 
Console.WriteLine("G = " + g.ToString("N2"));

// De olho na dica👀: Quando criamos testes com números do tipo float podemos encontrar um problema bem recorrente! Em culturas específicas, os números do tipo float são representados com , e em outras é representado com .. Com isso, precisamos definir qual cultura estamos usando no projeto .NET com a instrução:
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);