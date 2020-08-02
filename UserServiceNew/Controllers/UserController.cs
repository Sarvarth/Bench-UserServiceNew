using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace UserServiceNew.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET user/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _userService.GetUsersAsync(id);
        }
    }
}
