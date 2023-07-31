using System;

namespace BlazorApp1.Services
{
    public interface IConsumoAPI
    {
        public void SetEnderecoServidor(string enderecoServidor);
        public void Pesquisar(string url, ReqHeader reqHeader);
    }

    public interface IMainAPI : IConsumoAPI { }
    public interface ISecAPI : IConsumoAPI { }
}
