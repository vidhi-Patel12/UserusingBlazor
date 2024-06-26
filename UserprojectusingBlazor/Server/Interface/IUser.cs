using System.Web.Providers.Entities;
using UserprojectusingBlazor.Shared.Models;

namespace UserprojectusingBlazor.Server.Interface
{
    public interface IUserdetail
    {
        public List<UserClass> GetUserDetails();
        public void AddUser(UserClass user);
        public void UpdateUserDetails(UserClass user);
        public UserClass GetUserById(int id);
        public void DeleteUser(int id);
    }
}
