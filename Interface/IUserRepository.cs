using Sweady_training.Models;

namespace Sweady_training.Interface
{
    public interface IUserRepository
    {
        Task<User>GetUserByEmailAsync(string email);
        Task<User> CreateUserAsync(User user);
    }
}
