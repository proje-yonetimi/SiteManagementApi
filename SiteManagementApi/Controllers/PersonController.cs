using Microsoft.AspNetCore.Mvc;
using SiteManagementApi.Entities.Entities.User;
using SiteManagementApi.Operation.OperationManager;

namespace SiteManagementApi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet("")]
        public int abc()
        {
            //return UserOperation.GetUserInfo();
            return 0;
        }
    }
}

