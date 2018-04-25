using Dominio.Enums;

namespace Dominio.ObjetosValor
{
    public class Documento
    {
        public Documento(string numero, ETipoDocumento tipoDocumento)
        {
            Numero = numero;
            TipoDocumento = tipoDocumento;
        }
        public string Numero { get; private set; }
        public ETipoDocumento TipoDocumento { get; private set; }
    }
}
