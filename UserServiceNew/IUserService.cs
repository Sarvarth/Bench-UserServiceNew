using System.Threading.Tasks;

namespace UserServiceNew
{
    public interface IUserService
    {
        Task<User> GetUsersAsync(int id);
    }
}