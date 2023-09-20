using ArtLovers.Model.Interfaces;
using ArtLovers.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLovers.Model.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        protected ArtLoversContext _context;
        public bool _saveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _saveChanges = saveChanges;
            _context = new ArtLoversContext();
        } 
        public T Alterar(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_saveChanges)
            {
                _context.SaveChanges();
            }
            return obj;
        }

        public async Task<T> AlterarAsync(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_saveChanges)
            {
                await _context.SaveChangesAsync();
            }
            return obj;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Excluir(T obj)
        {
            _context.Set<T>().Remove(obj);
            if (_saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public async Task ExcluirAsync(T obj)
        {
            _context.Set<T>().Remove(obj);
            if (_saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }

        public async Task ExcluirAsync(params object[] variavel)
        {
            var obj = SelecionarPKAsync(variavel);
            ExcluirAsync(obj);
        }

        public T Incluir(T obj)
        {
            _context.Set<T>().Add(obj);
            if (_saveChanges)
            {
                _context.SaveChanges();
            }
            return obj;
        }

        public async Task<T> IncluirAsync(T obj)
        {
            _context.Set<T>().AddAsync(obj);
            if (_saveChanges)
            {
                _context.SaveChangesAsync();
            }
            return obj;
        }

        public T SelecionarPK(params object[] variavel)
        {
            var obj = _context.Set<T>().Find(variavel);
            return obj;
        }

        public async Task<T> SelecionarPKAsync(params object[] variavel)
        {
            var obj = await _context.Set<T>().FindAsync(variavel);
            return obj;
        }

        public List<T> SelecionarTodos()
        {
            var obj = _context.Set<T>().ToList();
            return obj;
        }

        public async Task<List<T>> SelecionarTodosAsync()
        {
            var obj = await _context.Set<T>().ToListAsync();
            return obj;
        }
    }
}
