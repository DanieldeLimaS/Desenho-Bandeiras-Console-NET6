

using Desenho_Bandeiras_Console_NET6.Interfaces;

namespace Desenho_Bandeiras_Console_NET6.Repository
{
    public class BandeiraRepository : IBandeiraRepository
    {
        public void fundoOriginal()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void ImprimirBandeiraDoBrasil(int qtdLinhas, int qtdColunas)
        {
            fundoOriginal();
            for (int linha = 0; linha < qtdLinhas; linha++)
            {
                for (int coluna = 0; coluna <= qtdColunas; coluna++)
                {
                    #region Pinta fundo de amarelo
                    if (linha == 0 && (coluna >= 15 && coluna <= 16))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 1 && (coluna >= 12 && coluna <= 19))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 2 && (coluna >= 9 && coluna <= 22))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 3 && (coluna >= 6 && coluna <= 25))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 4 && (coluna >= 3 && coluna <= 28))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 5 && ((coluna >= 0 && coluna <= 9) || (coluna >= 22 && coluna <= 32)))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 5 && (coluna >= 10 && coluna <= 22))
                    {
                        FundoBranco();
                    }

                    else if (linha == 6 && (coluna >= 3 && coluna <= 28))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 7 && (coluna >= 6 && coluna <= 25))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 8 && (coluna >= 9 && coluna <= 22))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 9 && (coluna >= 12 && coluna <= 19))
                    {
                        FundoAmarelo();
                    }
                    else if (linha == 10 && (coluna >= 15 && coluna <= 16))
                    {
                        FundoAmarelo();
                    }
                    #endregion
                    else FundoVerde();
                }
                fundoOriginal();
                Console.WriteLine();
            }
            fundoOriginal();
        }

        public void FundoBranco()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
        }

        public void FundoVerde()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
        }

        public void FundoAmarelo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
        }
    }
}
