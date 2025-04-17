namespace DiamantedeX.ConsoleApp;

/*
  * Desenvolver um programa em que, dado um número ímpar como entrada,
    exibirá um diamante desenhado com a letra 'X'.

    ● O programa deve solicitar ao usuário um número inteiro.
    ● O número deve ser ímpar. Caso contrário, o programa deve informar que
    a entrada é inválida e solicitar um novo número.
    ● O número de linhas e colunas deve ser igual ao número ímpar
    fornecido.
    ● A linha central do diamante deve conter o número máximo de Xs.
 */

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenuInicial();
            int tamanhoDiamante = ObterTamanhoDiamante();

            GeradorDeDiamante.DesenharDiamante(tamanhoDiamante);

            string opcaofinal = ExibirMenuFinal();
            if (opcaofinal == "R")
                continue;
            else if (opcaofinal == "S")
                break;
        }

    }

    public static void ExibirMenuInicial()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("                                                     Diamante de X");
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    }

    public static int ObterTamanhoDiamante()
    {
        int tamanhoDiamante;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Digite Um Número Inteiro Ímpar: ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            if (tamanhoDiamante <= 0)
            {
                Console.Clear();
                ExibirMenuInicial();
                Console.WriteLine();
                Console.WriteLine("                                              !O Número Deve Ser Positivo!");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                continue;
            }

            if (tamanhoDiamante == 1)
            {
                Console.Clear();
                ExibirMenuInicial();
                Console.WriteLine();
                Console.WriteLine("                                             !Digite Um Número Superior A 1!");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                continue;
            }

            if ((tamanhoDiamante / 2) * 2 == tamanhoDiamante)
            {
                Console.Clear();
                ExibirMenuInicial();
                Console.WriteLine();
                Console.WriteLine("                                                !O Número Deve ser Ímpar!");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                continue;
            }

          break;
        }
        return tamanhoDiamante;
    }

    private static string ExibirMenuFinal()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("!Pressione - R Para Reiniciar / S Para Sair!");

        string opcaofinal = Console.ReadLine().ToUpper();
        return opcaofinal;
    }


}
