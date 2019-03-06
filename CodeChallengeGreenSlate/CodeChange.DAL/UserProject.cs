using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge.DAL
{
    public class UserProject
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public bool IsActive { get; set; }
        public DateTime AssignedDate { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
