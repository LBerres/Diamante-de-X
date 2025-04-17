namespace DiamantedeX.ConsoleApp
{
    public static class GeradorDeDiamante
    {
        static int quantidadeDeLinhas;
        static int quantidadeDeX;
        static int quantidadeDeEspacos;

        public static void DesenharDiamante(int tamanhoDiamante)
        {
            quantidadeDeLinhas = (tamanhoDiamante - 1) / 2;
            quantidadeDeX = 1;
            quantidadeDeEspacos = quantidadeDeLinhas;

            ParteSuperior();

            ParteDoMeio(tamanhoDiamante);

            quantidadeDeX -= 2;
            quantidadeDeEspacos = 1;

            ParteInferior();
        }

        public static void ParteSuperior()
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
        public static void ParteDoMeio(int tamanhoDiamante)
        {
            for (int x = 0; x < tamanhoDiamante; x++)
                Console.Write("X");

            Console.WriteLine();
        }
        public static void ParteInferior()
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
