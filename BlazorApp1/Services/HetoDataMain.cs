using System.Diagnostics;

namespace BlazorApp1.Services
{
    public class HetoData : IHetoDataMain, IHetoDataSec
    {
        public HetoData(ReqHeader reqHeader, IConsumoAPI consumoAPI)
        {
            _reqHeader = reqHeader;
            this.consumoAPI = consumoAPI;
        }

        private readonly ReqHeader _reqHeader;
        private readonly IConsumoAPI consumoAPI;

        public void GetMovimentos()
        {
            consumoAPI.Pesquisar("api/Movimentos", _reqHeader);
        }
    }

    public class HetoDataMain : HetoData
    {
        public HetoDataMain(ReqHeader usuario, IMainAPI consumoAPI) : base(usuario, consumoAPI)
        {
        }
    }

    public class HetoDataSec : HetoData
    {
        public HetoDataSec(ReqHeader usuario, ISecAPI consumoAPI) : base(usuario, consumoAPI)
        {
        }
    }
    public static class DadosEstaticos
    {
    }
}