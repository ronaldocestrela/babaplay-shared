using System.Collections.ObjectModel;

namespace BabaPlayShared.Library.Constants;

public static class RoleConstants
{
    // NOTE: These are the default roles that are created when the application is first run. They should not be changed or removed, as they are used for seeding the database and for role-based authorization throughout the application.
    public const string Admin = nameof(Admin);
    public const string Basic = nameof(Basic);

    public static IReadOnlyList<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(
    [
        Admin,
        Basic
    ]);

    public static bool IsDefaultRole(string roleName) => DefaultRoles.Contains(roleName);
}
