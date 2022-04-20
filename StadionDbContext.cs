using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StadionTask.Data.Entities;

namespace StadionTask.Data.DAL
{
    internal class StadionDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WIN-IVUSE4PLT5F\SQLEXPRESS;DATABASE=StadionsDb;Trusted_Connection=True");
        }
        public DbSet<Stadion> Stadions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
    
}
