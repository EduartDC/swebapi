﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using swebapi.Data.Seed;
using swebapi.Models;

namespace swebapi.Data
{
    public class IdentityContext : IdentityDbContext<CustomIdentityUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }

        public DbSet<CustomIdentityUser> CustomIdentityUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedUserIdentityData();
        }
    }
}
