using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGreenSlate.Models.Home
{
    public class UserProject
    {
        public int ProjectID { get; set; }
        public string StartDate { get; set; }
        public string TimeToStart { get; set; }
        public string EndDate { get; set; }
        public int Credits { get; set; }
        public string Status { get; set; }
    }
}
