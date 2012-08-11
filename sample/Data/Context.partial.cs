﻿
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Data.Configurations;
using Data.Entities;
using Data.Repositories;

namespace Data
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
    		: this("DatabaseContext")
        {
        }
    
    	public DatabaseContext(string connectionString)
    		: base(connectionString)
    	{
    		Applications = new ApplicationRepository(this.Set<Application>());
    		Users = new UserRepository(this.Set<User>());
    		Tests = new TestRepository(this.Set<Test>());
    		ApplicationUsers = new ApplicationUserRepository(this.Set<ApplicationUser>());
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ApplicationConfiguration());
            modelBuilder.Configurations.Add(new ApplicationUserConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    
        public ApplicationRepository Applications { get; set; }
        public UserRepository Users { get; set; }
        public TestRepository Tests { get; set; }
        public ApplicationUserRepository ApplicationUsers { get; set; }
    }
}