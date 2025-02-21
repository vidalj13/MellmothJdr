using MellmothJdr.Services.Dto;

using NotificationManager.Infrastructure.Entities;

namespace MellmothJdr.Services.IServices
{
    public interface IJeuService : IScopableService
    {
        Task AddPartiesAsync(Partie newPartie, CancellationToken token);
        Task<JeuDto> GetJeuxAsync(Guid id, CancellationToken token);
        Task<List<PartieDto>> GetPartiesAsync(Guid idUserInterne, Guid gameId, CancellationToken token);
    }
}