using BuberDinner.Application.Persistence;
using BuberDinner.Domain.User;

namespace BuberDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new List<User>();
    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }

    public void Add(User user)
    {
        _users.Add(user);
    }
}