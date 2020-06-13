using System.Data.Entity;
using WCFTaskOneService.Domain.StudentsManagement;

namespace WCFTaskOneService.DataBase
{
    public class WCFTaskOneContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public WCFTaskOneContext() : base(@"Server=DESKTOP-KCSUK0G\BIDZINASQL; Database=WCFTaskOne; Trusted_Connection=True")
        {

        }
    }
}