using ApiFactura.data;
using ApiFactura.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiFactura.Repositorio
{
    public class Repos<T> : IRepos<T> where T : class
    {
        private readonly FacturaContext _db;
        internal DbSet<T> _DbSet;

        public Repos(FacturaContext db)
        {
            _db = db;
            this._DbSet = _db.Set<T>();
        }
        public async Task Create(T entity)
        {
            await _DbSet.AddAsync(entity);
            await Save();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = _DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task Remove(T entity)
        {
            _DbSet.Remove(entity);
            await Save();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
