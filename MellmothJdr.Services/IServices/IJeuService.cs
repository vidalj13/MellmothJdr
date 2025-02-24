using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.Services.Dto;

namespace MellmothJdr.Services.IServices
{
    public interface IJeuService : IScopableService
    {
        Task AddFichePersoChroniquesOubliesAsync(FichePersoChroniquesOublies fichePersoChroniquesOublies, CancellationToken none);
        Task AddPartiesAsync(Partie newPartie, CancellationToken token);
        Task<JeuDto> GetJeuxAsync(Guid id, CancellationToken token);
        Task<PartieDetailDto> GetPartieAsync(Guid idUserInterne, Guid gameId, Guid myGameId, CancellationToken token);
        Task<List<PartieDto>> GetPartiesAsync(Guid idUserInterne, Guid gameId, CancellationToken token);
    }
}