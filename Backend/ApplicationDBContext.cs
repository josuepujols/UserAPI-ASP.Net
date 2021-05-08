using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class ApplicationDBContext : DbContext
    {
        //Contructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }

        //DataSet
        public DbSet<User> UserTable { get; set; }
    }
}
