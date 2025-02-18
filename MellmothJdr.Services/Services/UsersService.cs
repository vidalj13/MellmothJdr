using MellmothJdr.Services.IServices;

using Microsoft.EntityFrameworkCore;

using NotificationManager.Infrastructure;
using NotificationManager.Infrastructure.Entities;

namespace MellmothJdr.Services.Services;

public class UsersService : IUsersService
{
    private BddContexte _contexte;

    public UsersService(BddContexte contexte)
    {
        _contexte = contexte;
    }

    public async Task<Guid> AddUserIfNotExistsAsync(User user, CancellationToken cancellationToken = default)
    {
        User old = await _contexte.Users.FirstOrDefaultAsync(x => x.ExterneId == user.ExterneId, cancellationToken);
        if(old != null)
        {
            return old.Id;
        }

        await _contexte.Users.AddAsync(user, cancellationToken);
        await _contexte.SaveBaseEntityChangesAsync(cancellationToken);
        return user.Id;
    }
}