using Microsoft.AspNetCore.Mvc;
using SiteManagementApi.Entities.Entities.User;
using SiteManagementApi.Operation.OperationManager;

namespace SiteManagementApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetUserInfo")]
        public List<User> Get()
        {
            return UserOperation.GetUserInfo();
        }
        [HttpGet("GetUserInfoById")]
        public List<User> Get(int userId)
        {
            return UserOperation.GetUserInfo(userId);
        }
    }
}
