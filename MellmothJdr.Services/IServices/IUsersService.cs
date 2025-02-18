using NotificationManager.Infrastructure.Entities;

namespace MellmothJdr.Services.IServices
{
    public interface IUsersService
    {
        Task<Guid> AddUserIfNotExistsAsync(User user, CancellationToken cancellationToken = default);
    }
}