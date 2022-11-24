namespace Users.Data;

/// <summary>
/// The users of our application.
/// </summary>
public class User
{
    /// <summary>
    /// Primary key.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Legal first name.
    /// </summary>
    public required string FirstName { get; set; }
    
    /// <summary>
    /// Legal last name(s).
    /// </summary>
    public required string LastName { get; set; }
    
    /// <summary>
    /// Valid email address.
    /// </summary>
    public required string Email { get; set; }
    
    /// <summary>
    /// Is this user account active.
    /// </summary>
    public bool Active { get; set; } = false;
    
    /// <summary>
    /// Is this user an admin.
    /// </summary>
    public bool Admin { get; set; } = false;
    
    /// <summary>
    /// User created DateTime in UTC.
    /// </summary>
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    /// DateTime this information was last modified in UTC.
    /// </summary>
    public DateTime LastModified { get; set; } = DateTime.UtcNow;
}