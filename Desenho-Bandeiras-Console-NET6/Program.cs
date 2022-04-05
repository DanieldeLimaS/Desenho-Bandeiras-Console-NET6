using System.Diagnostics;

interface IMensagem
{
    void PrintListArray(int linhas, int colunas);
    void fundoOriginal();
}
class Mensagem : IMensagem
{
    public void fundoOriginal()
    {
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public void PrintListArray(int qtdLinhas, int qtdColunas)
    {
        int colunaEsquerda = 14;
        int colunaDireita = 16;
        fundoOriginal();
        for (int linha = 0; linha < qtdLinhas; linha++)
        {
            if (linha == 1)
            {
                int teste = 0;
                teste++;
            }

            for (int coluna = 0; coluna <= qtdColunas; coluna++)
            {
                #region Pinta fundo de amarelo
                if (linha == 0 && (coluna >= 15 && coluna <= 16))
                {
                    addFundoAmarelo();
                }
                else if (linha == 1 && (coluna >= 12 && coluna <= 19))
                {
                    addFundoAmarelo();
                }
                else if (linha == 2 && (coluna >= 9 && coluna <= 22))
                {
                    addFundoAmarelo();
                }
                else if (linha == 3 && (coluna >= 6 && coluna <= 25))
                {
                    addFundoAmarelo();
                }
                else if (linha == 4 && (coluna >= 3 && coluna <= 28))
                {
                    addFundoAmarelo();
                }
                else if (linha == 5 && ((coluna >= 0&& coluna<=9) || (coluna>=22 &&coluna <= 32)))
                {
                    addFundoAmarelo();
                }
                else if (linha == 5 && (coluna >= 10 && coluna <= 22))
                {
                    addFundoBranco();
                }

                else if (linha == 6 && (coluna >= 3 && coluna <= 28))
                {
                    addFundoAmarelo();
                }
                else if (linha == 7 && (coluna >= 6 && coluna <= 25))
                {
                    addFundoAmarelo();
                }
                else if (linha == 8 && (coluna >= 9 && coluna <= 22))
                {
                    addFundoAmarelo();
                }
                else if (linha == 9 && (coluna >= 12 && coluna <= 19))
                {
                    addFundoAmarelo();
                }
                else if (linha == 10 && (coluna >= 15 && coluna <= 16))
                {
                    addFundoAmarelo();
                }
                #endregion

                else addFundoVerde();

               

            }

            fundoOriginal();
            Console.WriteLine();
        }
        fundoOriginal();
    }

    private void addFundoBranco()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(" ");
    }

    private void addFundoVerde()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write(" ");
    }

    private void addFundoAmarelo()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write(" ");
    }
}
static class Programa
{
    public static async Task Main()
    {
        IMensagem m = new Mensagem();
        while (true)
        {
            m.PrintListArray(11, 32);
            Thread.Sleep(1000);
            Console.Clear();
            m.fundoOriginal();
        }
    }
}