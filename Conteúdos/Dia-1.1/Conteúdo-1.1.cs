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