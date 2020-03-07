using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myapp.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}