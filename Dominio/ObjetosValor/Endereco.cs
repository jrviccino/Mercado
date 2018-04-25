using Dominio.Enums;

namespace Dominio.ObjetosValor
{
    public class Endereco
    {
        public ETipoEndereco TipoEndereco { get; private set; }
        public string TipoLogradouro { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }
    }
}
