using eCommerceNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceNet.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

  
        public DbSet<Product> product { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<Comment> comment { get; set; }
        public DbSet<User> user { get; set; }
    }
}
