using DBLab2.Models;
using DBLab2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLab2.Busines
{
	public class DeleteLogic
	{
		public void DeleteProject(int projectId)
		{
			var rep = new BaseRepository<Project>();
			rep.Delete(projectId);
		}
		public void DeleteTask(int taskId)
		{
			var rep = new BaseRepository<Task>();
			rep.Delete(taskId);
		}
		public void DeleteUser(int userId)
		{
			var rep = new BaseRepository<User>();
			rep.Delete(userId);
		}
		public void DeleteRole(int roleId)
		{
			var rep = new BaseRepository<Role>();
			rep.Delete(roleId);
		}
		public void DeleteMilestone(int milestoneId)
		{
			var rep = new BaseRepository<Milestone>();
			rep.Delete(milestoneId);
		}
		public void DeleteUserRole(int userRoleId)
		{
			var rep = new BaseRepository<UserRole>();
			rep.Delete(userRoleId);
		}
		public void DeleteMilestoneTask(int milestoneTaskId)
		{
			var rep = new BaseRepository<Project>();
			rep.Delete(milestoneTaskId);
		}
	}
}
