namespace DiamantedeX.ConsoleApp
{
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
        static int quantidadeDeLinhas;
        static int quantidadeDeX;
        static int quantidadeDeEspacos;

        static void Main(string[] args)
        {
            ExibirCabeçalho();
            int tamanhoDiamante = ObterTamanhoDiamante();

            quantidadeDeLinhas = (tamanhoDiamante - 1) / 2;
            quantidadeDeX = 1;
            quantidadeDeEspacos = quantidadeDeLinhas;

            ParteSuperior();

            ParteDoMeio(tamanhoDiamante);

            quantidadeDeX -= 2;
            quantidadeDeEspacos = 1;

            ParteInferior();

            Console.ReadLine();
        }
        static void ExibirCabeçalho()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                     Diamante de X");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine();
        }
        static int ObterTamanhoDiamante()
        {
            Console.Write("Digite Um Número Ímpar Positivo: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            return tamanhoDiamante;
        }
        static void ParteSuperior()
        {
            Console.WriteLine();

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                // Desenhar os Espaços da Linha
                for (int espaco = 0; espaco < quantidadeDeEspacos; espaco++)
                    Console.Write(" ");

                // Desenhar os X da Linha
                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("X");

                quantidadeDeX += 2;
                quantidadeDeEspacos--;

                Console.WriteLine();
            }
        }
        static void ParteDoMeio(int tamanhoDiamante)
        {
            for (int x = 0; x < tamanhoDiamante; x++)
                Console.Write("X");

            Console.WriteLine();
        }
        static void ParteInferior()
        {
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                // Desenhar os Espaços da Linha
                for (int espaco = 0; espaco < quantidadeDeEspacos; espaco++)
                    Console.Write(" ");

                // Desenhar os X da Linha
                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("X");

                quantidadeDeX -= 2;
                quantidadeDeEspacos++;

                Console.WriteLine();
            }
        }
    }
}
