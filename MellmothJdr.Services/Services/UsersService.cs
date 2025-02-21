using MellmothJdr.DAL.Entities;
using MellmothJdr.Services.IServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using NotificationManager.Infrastructure;

namespace MellmothJdr.Services.Services;

public class UsersService : ServiceBase, IUsersService
{
    public UsersService(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
    }

    public async Task<Guid> AddUserIfNotExistsAsync(User user, CancellationToken cancellationToken = default)
    {
        using BddContexte contexte = GetScopedBddContexte();
        User old = await contexte.Users.FirstOrDefaultAsync(x => x.ExterneId == user.ExterneId, cancellationToken);
        if (old != null)
        {
            return old.Id;
        }

        await contexte.Users.AddAsync(user, cancellationToken);
        await contexte.SaveBaseEntityChangesAsync(cancellationToken);
        return user.Id;
    }
}