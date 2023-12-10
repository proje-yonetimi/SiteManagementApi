using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using SiteManagementApi.DatabaseContext.Context;
using SiteManagementApi.DatabaseContext.Entities;
using SiteManagementApi.Operation.Classes;

namespace SiteManagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public List<User> Get()
        {
            var userInfo = UserInfo.GetUserInfo();
            
            return userInfo;
        }
        //[HttpGet(Name = "GetUser")]
        //public List<User> GetUser()
        //{
        //    List<User> tuser;
        //    SpCall sp = new SpCall("dbo.GetUserDetail");
        //    sp.SetInt("@UserId", 1);

        //    SSOContext sContext = new SSOContext();
        //    using (sContext)
        //    {
        //        tuser = sContext.Users.FromSqlRaw(sp.ToString()).ToList();
        //    }
        //    return tuser;
        //}
    }
}
