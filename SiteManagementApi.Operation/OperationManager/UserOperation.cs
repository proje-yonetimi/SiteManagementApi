using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Business.Interfaces;
using SiteManagementApi.DatabaseContext.Context;
using SiteManagementApi.Entities.Entities.User;

namespace SiteManagementApi.Operation.OperationManager
{
    public class UserOperation : IUser
    {
        public static List<User> GetUserInfo(int? userId = 0)
        {
            List<User> tuser;
            List<User> sonUser;
            SpCall sp = new SpCall("dbo.GetUserDetail");
            if (userId != 0)
            {
                sp.SetInt("@UserId", userId);
            }

            SSOContext sContext = new SSOContext();
            using (sContext)
            {
                User us;
                tuser = sContext.Users.FromSqlRaw(sp.ToString()).ToList();
                sonUser = new List<User>();
                foreach (User user in tuser)
                {
                    us = new User();
                    us.Name = user.Name;
                    us.Surname = user.Surname;
                    us.UserName = user.UserName;
                    sonUser.Add(us);
                }
            }

            return sonUser;
        }

        public List<User> GetUserAll()
        {
            List<User> user = new List<User>();
            return user;
        }

        public List<User> GetUserInfo(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
