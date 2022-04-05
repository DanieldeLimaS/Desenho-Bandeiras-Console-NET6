using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenho_Bandeiras_Console_NET6.Interfaces
{
    public interface IBandeiraRepository
    {
        void ImprimirBandeiraDoBrasil(int linhas, int colunas);
        void fundoOriginal();
        void FundoBranco();
        void FundoAmarelo();
        void FundoVerde();
    }
}
