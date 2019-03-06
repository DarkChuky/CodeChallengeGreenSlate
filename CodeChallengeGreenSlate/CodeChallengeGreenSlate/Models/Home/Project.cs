using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGreenSlate.Models.Home
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }

        /*
         Id INT PK NOT NULL

StartDate DATETIME NOT NULL

EndDate DATETIME NOT NULL

Credits INT NOT NULL 
         */

    }
}
