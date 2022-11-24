using Users.Data;

namespace Users;

/// <summary>
/// GraphQL queries.
/// </summary>
public class Query
{
    /// <summary>
    /// Get any and all users, supports filtering and sorting.
    /// </summary>
    /// <param name="context">DI.</param>
    /// <returns>List of users.</returns>
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<User> GetUsers([Service] DataContext context)
    {
        return context.Users;
    }
}