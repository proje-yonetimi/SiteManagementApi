using SiteManagementApi.Entities.Entities.User;

namespace SiteManagementApi.Business.Interfaces
{
    public interface IUser
    {
        List<User> GetUserAll();
        List<User> GetUserInfo(int userId);

        //bool SetUserInfoSave(User user);

        //bool DeleteUserInfo(int User);

    }
}
