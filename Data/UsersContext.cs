using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Users.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("name=UsersContext")
        {
        }

        public System.Data.Entity.DbSet<Users.Models.User> Users { get; set; }
    }
}
