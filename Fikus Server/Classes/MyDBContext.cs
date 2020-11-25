using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Fikus_Server.Classes
{
    class MyDBContext:DbContext
    {
        public MyDBContext() : base("conString")
        {



        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
    }
}
