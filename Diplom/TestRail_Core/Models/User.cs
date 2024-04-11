using TestRail_Core.Models.Enums;

namespace TestRail_Core.Models;

public class User
{
    public UserType UserType { get; set; }
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}