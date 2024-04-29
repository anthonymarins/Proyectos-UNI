using ApiFactura.data;
using ApiFactura.Modelo;

namespace ApiFactura.Repositorio.IRepositorio
{
    public class ProductosRepos : Repos<Productos>, IProductos
    {
        private readonly FacturaContext _db;
        public ProductosRepos(FacturaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<List<Productos>> GetAll(int entity)
        {
            var query = from p in _db.productos.ToList()
                        where p.id == entity
                        select p;
            return query.ToList();
        }

        public async Task<Productos> Update(Productos entity)
        {
            _db.productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
