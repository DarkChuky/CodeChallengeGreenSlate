using System;
using System.Collections.Generic;
using System.Text;
using CodeChallenge.ModelDomain;

namespace CodeChallenge.BLL.Interface
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
        List<UserProject> GetUserProject(int userId);
    }
}
