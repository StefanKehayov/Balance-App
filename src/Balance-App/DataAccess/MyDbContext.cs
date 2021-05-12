﻿using System;
using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;
using Microsoft.Extensions.Configuration;


namespace Balance_App.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<UserToBalance> UserToBalances { get; set; }
        public MyDbContext()
        {
            Users = this.Set<User>();
            Balance = this.Set<Balance>();
            Bills = this.Set<Bill>();
            UserToBalances = this.Set<UserToBalance>();
        }


     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();
    optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    /* optionsBuilder.UseSqlServer(configuration.GetConnectionString("MsSql"));  */
    }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    FirstName = "Admin",
                    LastName = "Admin"
                });
        }
    }

}