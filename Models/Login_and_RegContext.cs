using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Login_and_Reg.Models
{
    public class Login_and_RegContext : DbContext
    {
        public Login_and_RegContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users { get; set; }
    }
}