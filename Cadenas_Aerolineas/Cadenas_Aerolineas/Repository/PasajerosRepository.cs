using Cadenas_Aerolineas.Data;
using Cadenas_Aerolineas.Models;
using Cadenas_Aerolineas.Repository.IRepository;

namespace Cadenas_Aerolineas.Repository
{
    public class PasajerosRepository : Repository<Pasajeros>, IPasajerosRepository
    {
        private readonly AerolineaContext _db;

        public PasajerosRepository(AerolineaContext db): base(db)
        {
            _db = db;
        }

        public async Task<Pasajeros> Update(Pasajeros entity)
        {
            _db.Peliculas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
