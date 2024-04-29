using Cadenas_Aerolineas.Data;
using Cadenas_Aerolineas.Models;
using Cadenas_Aerolineas.Repository.IRepository;

namespace Cadenas_Aerolineas.Repository
{
    public class PaisesRepository : Repository<Paises>, IPaisesRepository
    {
        private readonly AerolineaContext _db;

        public PaisesRepository(AerolineaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Paises> Update(Paises entity)
        {
            _db.Paises.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
