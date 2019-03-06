using CodeChallenge.BLL.Interface;
using CodeChallenge.ModelDomain;
using CodeChallenge.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge.BLL
{
    public class UserManager : IUserManager
    {
        public List<CodeChallenge.ModelDomain.User> GetAllUsers()
        {
            using (CodeChallengeContext contex = new CodeChallengeContext())
            {
                List<ModelDomain.User> result = new List<ModelDomain.User>();

                List<DAL.User> resultDB = contex.User.ToList();

                //From Entity object to Domain object (example in case of DB first and heavy Entity objects)
                resultDB.ForEach(e =>
                {

                    ModelDomain.User user = new ModelDomain.User();
                    user.Id = e.Id;
                    user.FirstName = e.FirstName;
                    user.LastName = e.LastName;

                    result.Add(user);
                });
                return result;
            }
        }

        public List<ModelDomain.UserProject> GetUserProject(int userId)
        {

            List<ModelDomain.UserProject> result = new List<ModelDomain.UserProject>();
            using (CodeChallengeContext contex = new CodeChallengeContext())
            {

                //get the user data
                DAL.User user = contex.User.Where(u => u.Id == userId).Single();

                //include("User").Include("Project") or a Select with joins of just the required field is faster, 
                //just doing example of multiple DB access in a BLL

                List<DAL.UserProject> resultDB = contex.UserProject.Where(e => e.UserId == userId).ToList();

                resultDB.ForEach(e =>
                {
                    ModelDomain.UserProject uResult = new ModelDomain.UserProject();

                    uResult.User = new ModelDomain.User();
                    uResult.User.Id = user.Id;
                    uResult.User.FirstName = user.FirstName;
                    uResult.User.LastName = user.LastName;

                    //get project from DB
                    DAL.Project project = contex.Project.Where(p => p.Id == e.ProjectId).Single();
                    uResult.Project = new ModelDomain.Project();

                    uResult.Project.Id = project.Id;
                    uResult.Project.StartDate = project.StartDate;
                    uResult.Project.EndDate = project.EndDate;
                    uResult.Project.Credits = project.Credits;

                    result.Add(uResult);
                });
            }
            return result;
        }
    }
}
