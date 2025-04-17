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
            MenuInicial();
            int tamanhoDiamante = ObterTamanhoDiamante();

            GeradorDeDiamante.DesenharDiamante(tamanhoDiamante);

            string opcaofinal = OpçõesFinais();
            if (opcaofinal == "R")
                continue;
            else if (opcaofinal == "S")
                break;
        }

    }

    public static void MenuInicial()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                                     Diamante de X");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        Console.WriteLine();
    }

    public static int ObterTamanhoDiamante()
    {
        Console.Write("Digite Um Número Ímpar Positivo: ");
        int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        return tamanhoDiamante;
    }

    private static string OpçõesFinais()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("!Pressione - R Para Reiniciar / S Para Sair!");

        string opcaofinal = Console.ReadLine().ToUpper();
        return opcaofinal;
    }


}
