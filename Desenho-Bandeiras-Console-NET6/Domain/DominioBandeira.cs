using Desenho_Bandeiras_Console_NET6.Interfaces;
using Desenho_Bandeiras_Console_NET6.Repository;

namespace Desenho_Bandeiras_Console_NET6.Domain
{
    public class DominioBandeira
    {
        public DominioBandeira()
        {

        }
        public void ImprimirBandeiraBrasil(int linhas, int colunas)
        {
            IBandeiraRepository bandeiraRepository = new BandeiraRepository();
            bandeiraRepository.ImprimirBandeiraDoBrasil(linhas, colunas);
        }
    }
}
