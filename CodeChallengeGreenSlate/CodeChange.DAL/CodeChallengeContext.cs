using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge.DAL
{
    
    public class CodeChallengeContext : DbContext
    {
        public CodeChallengeContext()
            : base()
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<UserProject> UserProject { get; set; }
    }
    
}
