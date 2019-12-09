using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_Wxam.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=MyContext")
        {

        }
        public DbSet<Subject> ExamId { get; set; }
    }
}