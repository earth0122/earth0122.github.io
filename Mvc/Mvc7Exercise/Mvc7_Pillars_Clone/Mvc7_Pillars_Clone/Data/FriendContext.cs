using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc7_Pillars_Clone.Models;

namespace Mvc7_Pillars_Clone.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext (DbContextOptions<FriendContext> options)
            : base(options)
        {
        }

        public DbSet<Mvc7_Pillars_Clone.Models.Friend> Friend { get; set; } = default!;

        public DbSet<Mvc7_Pillars_Clone.Models.Employee> Employee { get; set; } = default!;
    }
}
