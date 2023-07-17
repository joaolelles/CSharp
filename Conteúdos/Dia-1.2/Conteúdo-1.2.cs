// Cast Implícito
public class Program
{
    public static void Main()
    {
        int someIntNumber = 51;
        long longNumberCast = someIntNumber;

        Console.WriteLine(longNumberCast);
    }
}

// Cast Explícito
public class Program
{
    public static void Main()
    {
        long someLongNumber = 516144066604654;
        int intNumber = (int)someLongNumber;

        Console.WriteLine(intNumber);
    }
}

// utilizando o Convert
public class Program
{
    public static void Main()
    {
        long someLongNumber = 516144564564654;
        int intNumber = Convert.ToInt32(someLongNumber);
        Console.WriteLine(intNumber);
    }
}

// utilizando o TryParse
bool canConvert = Int32.TryParse(userEntry, out valueConverted)


// Estrutura de seleção múltipla switch/case
switch (number)
{
    case > 0:
        Console.WriteLine("maior que 0");
        break;
    case 0:
        Console.WriteLine("igual a zero");
        break;
    default:
        Console.WriteLine("menor que zero");
        break;
    }

// Operadores de comparação no C#
> Maior   a > b   Se a for maior que b
>= Maior ou igual  a >= b  Se a for maior ou igual a b
< Menor   a < b   Se a for menor que b
<= Menor ou igual  a <= b  Se a for menor ou igual a b
== Igual   a == b  Se a for igual a b
!= Diferente   a != b  Se a for diferente de b

// Operadores lógicos do C#
&& AND / E   a > b && b < 4  Verdade se todas as expressões lógicas forem avaliadas como verdadeiras
|| OR / Ou   a > b || b < 4  Verdade se pelo menos uma expressão lógica for avaliada como verdadeira
!   NOT / Não!(a > b)    É uma expressão de negação, sendo assim, inverterá o valor da expressão


// Exemplo de função usando o switch/case
public static string IdentifyPolygon(int sideCount)
                                {
                                    var name = string.Empty;
                                    switch (sideCount)
                                    {
                                        case < 3:
                                            name = "Não é um polígono";
                                            break;
                                        case 3:
                                            name = "Triângulo";
                                            break;
                                        case 4:
                                            name = "Quadrado";
                                            break;
                                        case 5:
                                            name = "Pentágono";
                                            break;
                                        default:
                                            name = "Polígono não identificado";
                                            break;
                                    }
                                    return name;
                                }