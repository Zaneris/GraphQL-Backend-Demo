using HotChocolate.Execution;
using Users.Data;

namespace Users;

/// <summary>
/// GraphQL mutations.
/// </summary>
public class Mutation
{
    private static readonly IError ErrorUserNotFound = ErrorBuilder.New()
        .SetMessage("User not found.")
        .SetCode("U001")
        .Build();
    
    /// <summary>
    /// Activate/deactivate user with provided user ID.
    /// </summary>
    /// <param name="context">DI.</param>
    /// <param name="userId">User to activate.</param>
    /// <param name="active">Set user active to true/false.</param>
    /// <returns>Updated user.</returns>
    public async Task<User> UserActiveSet([Service] DataContext context, int userId, bool active)
    {
        var user = await context.Users.FindAsync(userId);
        if (user is null)
            throw new QueryException(ErrorUserNotFound);
        user.Active = active;
        await context.SaveChangesAsync();
        return user;
    }
    
    /// <summary>
    /// Enable/disable admin for user with provided user ID.
    /// </summary>
    /// <param name="context">DI.</param>
    /// <param name="userId">User to enable admin for.</param>
    /// <param name="admin">Set user admin to true/false.</param>
    /// <returns>Updated user.</returns>
    public async Task<User> UserAdminSet([Service] DataContext context, int userId, bool admin)
    {
        var user = await context.Users.FindAsync(userId);
        if (user is null)
            throw new QueryException(ErrorUserNotFound);
        user.Admin = admin;
        await context.SaveChangesAsync();
        return user;
    }
}