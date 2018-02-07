using AzR.Core.Models;
using AzR.Mef.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.Composition;
using System.Data.Entity;

namespace AzR.Core.Repositories
{
    [Export(typeof(IAppDbContext))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IAppDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
