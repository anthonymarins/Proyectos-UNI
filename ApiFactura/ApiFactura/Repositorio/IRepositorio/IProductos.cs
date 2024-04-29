using ApiFactura.Modelo;

namespace ApiFactura.Repositorio.IRepositorio
{
    public interface IProductos : IRepos<Productos>
    {
        Task <Productos> Update(Productos entity);

        Task<List<Productos>> GetAll(int entity);
    }
}
