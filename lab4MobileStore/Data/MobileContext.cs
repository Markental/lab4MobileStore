﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab4MobileStore.Models;
using Microsoft.EntityFrameworkCore;

namespace lab4MobileStore.Data
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public MobileContext(DbContextOptions<MobileContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=mobilestoredb.db");
        }
    }
}
