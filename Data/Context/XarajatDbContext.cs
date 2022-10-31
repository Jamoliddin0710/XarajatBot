using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class XarajatDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Outlay> Outlays { get; set; }
        public XarajatDbContext(DbContextOptions options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.ApplyConfigurationsFromAssembly(typeof(XarajatDbContext).Assembly);
        }

    }
}
