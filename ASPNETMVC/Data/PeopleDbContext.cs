using ASPNETMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETMVC.Data
{
    // has the information related all the tables for EF: IM
    public class PeopleDbContext: DbContext
    {
        public DbSet<IUser> Users { get; set; }

        public DbSet<IName> Names { get; set; }

        public DbSet<IPicture> Pictures { get; set; }

        public PeopleDbContext(DbContextOptions options): base(options) { }
    }

}
