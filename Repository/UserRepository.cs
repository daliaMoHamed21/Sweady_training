using Microsoft.EntityFrameworkCore;
using Sweady_training.Data;
using Sweady_training.Interface;
using Sweady_training.Models;

namespace Sweady_training.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context ;

        public UserRepository(UserContext contexr) { }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.user.FirstOrDefaultAsync(u=>u.Email  == email);
        }

        public async Task<User> CreateUserAsync(User user)
        {
           _context.user.Add(user);
            await _context.SaveChangesAsync();
            return user;


        }
    }
}
