namespace DiamantedeX.ConsoleApp
{
    internal class Program
    {/*
      * Desenvolver um programa em que, dado um número ímpar como entrada,
        exibirá um diamante desenhado com a letra 'X'.

        ● O programa deve solicitar ao usuário um número inteiro.
        ● O número deve ser ímpar. Caso contrário, o programa deve informar que
        a entrada é inválida e solicitar um novo número.
        ● O número de linhas e colunas deve ser igual ao número ímpar
        fornecido.
        ● A linha central do diamante deve conter o número máximo de Xs.
     */
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                     Diamante de X");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine();

            Console.Write("Digite Um Número Ímpar Positivo: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            int quantidadeDeLinhas = (tamanhoDiamante - 1) /2;
            int quantidadeDeX = 1;
            int quantidadeDeEspacos = quantidadeDeLinhas;

            Console.WriteLine();

            #region Parte Superior
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
            #endregion

            #region Parte do Meio
            for (int x = 0; x < tamanhoDiamante; x++)
                Console.Write("X");

            Console.WriteLine();
            #endregion

            quantidadeDeX -= 2;
            quantidadeDeEspacos = 1;

            #region Parte Inferior
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
            #endregion

            Console.ReadLine();
        }
    }
}
