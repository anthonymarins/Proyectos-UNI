using System.Linq.Expressions;

namespace ApiFactura.Repositorio.IRepositorio
{
    public interface IRepos<T> where T : class
    {
        Task Create(T entity);
        Task <List<T>> GetAll(Expression<Func<T, bool>>? filter = null);
        Task Remove (T entity);
        Task Save();
    }
}
