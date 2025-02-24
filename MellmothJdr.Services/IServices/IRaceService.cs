using MellmothJdr.DAL.Entities;

namespace MellmothJdr.Services.IServices
{
    public interface IRaceService : IScopableService
    {
        Task<List<Race>> GetRacesAsync(Guid gameId, CancellationToken none);
    }
}