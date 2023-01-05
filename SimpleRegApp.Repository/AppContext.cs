using Microsoft.AspNet.Identity.EntityFramework;
using SimpleRegApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRegApp.Repository
{
    public class AppContext: IdentityDbContext
    {
        public AppContext()
        {
            
        }
        public AppContext(string conStr) : base(conStr) { }

        public DbSet<UserInformation> userInformationTbl { get; set; }
    }

}
