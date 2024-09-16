using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WingHerryTask.Models
{
    public class WingDbContext:DbContext
    {
        public WingDbContext():base("Constr")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WingDbContext>());
        }
        public DbSet<User> Users { get; set; }
    }
}