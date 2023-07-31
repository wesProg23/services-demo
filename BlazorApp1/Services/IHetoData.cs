using System.Diagnostics;

namespace BlazorApp1.Services
{
    public interface IHetoData
    {
        public void GetMovimentos();
    }
    public interface IHetoDataMain : IHetoData { }
    public interface IHetoDataSec : IHetoData{ }
}