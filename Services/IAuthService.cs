using TaskManager.Entities;
using TaskManager.Models;

namespace TaskManager.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string> LoginAsync(UserDto request);
    }
}
