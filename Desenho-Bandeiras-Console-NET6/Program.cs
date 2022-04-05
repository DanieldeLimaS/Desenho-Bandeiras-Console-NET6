
using Desenho_Bandeiras_Console_NET6.Domain;

static class Programa
{
    public static async Task Main()
    {
        DominioBandeira dominioBandeira = new DominioBandeira();
        dominioBandeira.ImprimirBandeiraBrasil(11, 32);
    }
}