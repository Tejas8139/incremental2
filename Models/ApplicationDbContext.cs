﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 
namespace dotnetapp.Models;

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
 
        public virtual DbSet<Player> Players{get;set;}
 
        public virtual DbSet<Team> Teams{get;set;}
 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
    }
