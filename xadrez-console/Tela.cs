using System;
using tabuleiro;


namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca == null){
                        Console.Write(tab.peca(i, j) + " ");
                    } else
                    {
                        Console.Write(" - ");
                    }
                    
                }
                Console.WriteLine();
            }
}
    }
}
