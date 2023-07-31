using Microsoft.AspNetCore.Http.Headers;
using System.Diagnostics;

namespace BlazorApp1.Services
{
    public class ConsumoAPI : IMainAPI, ISecAPI
    {
        private readonly Guid _id;
        private string _enderecoServidor = "";

        public ConsumoAPI()
        {
            _id = Guid.NewGuid();
        }

        public void Pesquisar(string url, ReqHeader reqHeader)
        {
            Debug.WriteLine($"HttpTalz, Endereco:{_enderecoServidor}/{url} id: " + _id.ToString());
        }

        public void SetEnderecoServidor(string enderecoServidor)
        {                
            _enderecoServidor = enderecoServidor;
        }

    }
}