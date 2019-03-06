using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGreenSlate.Models.Home
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get {
                if (LastName == String.Empty)
                {
                    return FirstName;
                }
                return FirstName + ' ' + LastName;
            }
        }

    }
}
