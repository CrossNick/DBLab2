using DBLab2.Models;
using DBLab2.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DBLab2.Busines
{
	public class AddLogic
	{
		Querys _query;
		public AddLogic()
		{
			_query = new Querys();
		}
		public void AddProject(string projectName)
		{
			var rep = new BaseRepository<Project>();
			var newItem = new Project() { Name = projectName };
			rep.Create(newItem);
		}

		public void AddUser(string userName, string firstName, string lastName, string email, string password)
		{
			var rep = new BaseRepository<User>();
			var newItem = new User() { UserName = userName, FirstName = firstName, LastName = lastName, Email = email, Password=password };
			rep.Create(newItem);
		}

		public void AddTask(string taskName, string desctiption, string creationDate, string dueDate, int projectId, int userId)
		{
			_query.InsertTask(taskName, desctiption, creationDate, dueDate, projectId, userId);
		}

		public void AddMilestone(string mlName, string startDate, string endDate, int userId)
		{
			_query.InsertMilestone( mlName,  startDate,  endDate,  userId);
		}

		public void AddRole(string roleName)
		{
			var rep = new BaseRepository<Role>();
			var newItem = new Role() { Name = roleName };
			rep.Create(newItem);
		}

		public void AddUserRole(int userId, int roleId, int projectId)
		{
			_query.InsertUserRole( userId,  roleId,  projectId);
		}

		public void AddMilestoneTask(int mlId, int taskId)
		{
			_query.InsertMilestoneTask( mlId,  taskId);
		}

	}
}
