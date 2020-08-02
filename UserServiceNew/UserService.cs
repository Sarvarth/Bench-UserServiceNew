using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using UserServiceNew.Database;

namespace UserServiceNew
{
    public class UserService : IUserService
    {
        private readonly Func<UserContext> _dbContextProvider;

        public UserService(Func<UserContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }
        public async Task<User> GetUsersAsync(int id)
        {
            var user = new User
            {
                UserId = id,
                Name = "DefaultName",
                Email = "DefaultEmail"
            };

            using (var context = _dbContextProvider())
            {
                return await context.User.FirstOrDefaultAsync(x => x.UserId == id) ?? user;
            }
        }
    }
}
