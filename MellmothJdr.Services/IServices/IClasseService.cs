using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;

namespace MellmothJdr.Services.IServices
{
    public interface IClasseService : IScopableService
    {
        Task<List<Classe>> GetClassesAsync(Guid gameId, CancellationToken none);
        Task<List<VoieChroniquesOublies>> GetVoieChroniquesOubliesForClassesAsync(Guid classeId, CancellationToken none);
    }
}