using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGreenSlate.Models.Home
{
    public class Users
    {
        [Display(Name = "Users")]
        public int SelectedUserId { get; set; }
        public IEnumerable<SelectListItem> UserList { get; set; }
    }
}
