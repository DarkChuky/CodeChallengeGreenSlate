using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeChallengeGreenSlate.Models.Home;
using CodeChallenge.BLL.Interface;
using CodeChallenge.BLL;
using CodeChallenge.ModelDomain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeChallengeGreenSlate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            IUserManager userManager = new UserManager();

            List<CodeChallenge.ModelDomain.User> users = userManager.GetAllUsers();
            List<Models.Home.User> modelUsers = new List<Models.Home.User>();

            users.ForEach(e => {
                Models.Home.User u = new Models.Home.User();
                u.Id = e.Id;
                u.FirstName = e.FirstName;
                u.LastName = e.LastName;
                modelUsers.Add(u);
            });

            var roles = modelUsers
               .Select(x =>
                       new SelectListItem
                       {
                           Value = x.Id.ToString(),
                           Text = x.FullName
                       });

            Users userResult = new Users();
            userResult.UserList = new SelectList(roles, "Value", "Text");

            return View(userResult);
        }

        public JsonResult GetUserProjects(int userId)
        {
            IUserManager userManager = new UserManager();
            List< CodeChallenge.ModelDomain.UserProject> userProject = userManager.GetUserProject(userId);

            List<Models.Home.UserProject> userProjectResult = new List<Models.Home.UserProject>();

            foreach (CodeChallenge.ModelDomain.UserProject userP in userProject)
            {
                Models.Home.UserProject uProject = new Models.Home.UserProject();
                uProject.ProjectID = userP.ProjectId;
                uProject.StartDate = userP.Project.StartDate.ToString("MM/dd/yyyy");
                int daysToStart = (userP.Project.StartDate - userP.AssignedDate).Days;
                uProject.TimeToStart = daysToStart < 0 ? "Started" : daysToStart.ToString();
                uProject.EndDate = userP.Project.EndDate.ToString("MM/dd/yyyy");
                uProject.Credits = userP.Project.Credits;
                uProject.Status = userP.IsActive.ToString();
                userProjectResult.Add(uProject);
            }
            return Json(userProjectResult);

        }
    }
}