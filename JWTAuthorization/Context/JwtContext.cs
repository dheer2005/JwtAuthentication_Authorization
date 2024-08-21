﻿using JWTAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthorization.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {
            
        } 

        public DbSet<User> Users { get; set; }  
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }  
        public DbSet<Employee> Employees { get; set; }

    }
}
