using Cadenas_Aerolineas.Models;

namespace Cadenas_Aerolineas.Repository.IRepository
{
    public interface IPasajerosRepository : IRepository<Pasajeros>
    {
        Task<Pasajeros> Update(Pasajeros entity);
    }
}
