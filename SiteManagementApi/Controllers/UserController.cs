using Microsoft.AspNetCore.Mvc;
using SiteManagementApi.DatabaseContext.Entities;
using SiteManagementApi.Operation.Classes;

namespace SiteManagementApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetUserInfo")]
        public List<User> Get()
        {
            return UserInfo.GetUserInfo();
        }
        [HttpGet("GetUserInfoById")]
        public List<User> Get(int userId)
        {
            return UserInfo.GetUserInfo(userId);
        }
    }
}
