namespace BlazorApp1.Services
{
    public class ReqHeader
    {
        public void SetReqHeader(string usuarioLogado, string empresaLogada, string nomePC, string navegador, string oS)
        {
            UsuarioLogado = usuarioLogado;
            EmpresaLogada = empresaLogada;
            NomePC = nomePC;
            Navegador = navegador;
            OS = oS;
        }

        public string UsuarioLogado { get; set; } = "";
        public string EmpresaLogada { get; set; } = "";
        public string NomePC { get; set; } = "";
        public string Navegador { get; set; } = "";
        public string OS { get; set; } = "";
    }
}
