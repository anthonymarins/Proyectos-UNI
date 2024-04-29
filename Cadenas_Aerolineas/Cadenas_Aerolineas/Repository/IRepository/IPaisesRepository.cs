using Cadenas_Aerolineas.Models;

namespace Cadenas_Aerolineas.Repository.IRepository
{
    public interface IPaisesRepository : IRepository<Paises>
    {
        Task<Paises> Update(Paises entity);
    }
}
