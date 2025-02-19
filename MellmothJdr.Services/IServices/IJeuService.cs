using MellmothJdr.Services.Dto;

namespace MellmothJdr.Services.IServices
{
    public interface IJeuService
    {
        Task<JeuDto> GetJeuxAsync(Guid id, CancellationToken token);
    }
}