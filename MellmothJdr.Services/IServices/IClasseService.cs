using MellmothJdr.DAL.Entities;

namespace MellmothJdr.Services.IServices
{
    public interface IClasseService : IScopableService
    {
        Task<List<Classe>> GetClassesAsync(Guid gameId, CancellationToken none);
    }
}