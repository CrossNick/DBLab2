using DBLab2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DBLab2
{
	class BTDbContext : DbContext
	{
	

		public BTDbContext() : base("DefaultConnection")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Project>().ToTable("Project");
			modelBuilder.Entity<Task>().ToTable("Task");
			modelBuilder.Entity<Milestone>().ToTable("Milestone");
			modelBuilder.Entity<Role>().ToTable("Role");
			modelBuilder.Entity<User>().ToTable("User");
			modelBuilder.Entity<UserRole>().ToTable("UserRole");
			modelBuilder.Entity<MilestoneTask>().ToTable("MilestoneTask");
		}

	}
}
