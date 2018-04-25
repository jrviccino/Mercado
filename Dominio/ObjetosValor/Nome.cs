using Shared.ObjetosValor;

namespace Dominio.ObjetosValor
{
    public class Nome : ObjetoValor
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}
