using ArtLovers.Model.Models;
using ArtLovers.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLovers.Model.Interfaces
{
    public class IRepositoryPessoa : IRepositoryBase<Pessoa>
    {
        public Pessoa Alterar(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoa> AlterarAsync(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public Pessoa Incluir(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoa> IncluirAsync(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public Pessoa SelecionaPK(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoa> SelecionarPKAsync(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Pessoa>> SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
