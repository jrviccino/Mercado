using Dominio.Enums;
using Dominio.ObjetosValor;
using Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Dominio.Entidades
{
    public class Pessoa : Entidade
    {
        private IList<Endereco> _enderecos;
        private IList<Documento> _documentos;
        private IList<Contato> _contatos;
        public Pessoa(Nome nome, DateTime dataNascimento, ETipoPessoa tipoPessoa, Email email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            TipoPessoa = tipoPessoa;
            Email = email;
            _enderecos = new List<Endereco>();
            _documentos = new List<Documento>();
            _contatos = new List<Contato>();
            AddNotifications(nome, email);
        }
        public Nome Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public ETipoPessoa TipoPessoa { get; private set; }
        public IReadOnlyCollection<Documento> Documentos { get { return _documentos.ToArray(); } }
        public IReadOnlyCollection<Endereco> Enderecos { get { return _enderecos.ToArray(); } }
        public IReadOnlyCollection<Contato> Contatos { get { return _contatos.ToArray(); } }
        public Email Email { get; private set; }
        public void AdicionarEndereco(Endereco endereco)
        {
            _enderecos.Add(endereco);
        }
        public void AdicionarDocumento(Documento documento)
        {
            _documentos.Add(documento);
        }
        public void AdicionarContato(Contato contato)
        {
            _contatos.Add(contato);
        }
    }
}
