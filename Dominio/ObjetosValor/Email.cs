using Dominio.Enums;
using Shared.ObjetosValor;

namespace Dominio.ObjetosValor
{
    public class Email : ObjetoValor
    {
        public ETipoEmail TipoEmail { get; private set; }
        public string Endereco { get; private set; }
    }
}
