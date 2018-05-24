using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBLab2.Models;
using DBLab2.Repositories;

namespace DBLab2.Busines
{
    public class GetLogic
    {
		public IEnumerable<Project> GetProjects()
		{
			var rep = new BaseRepository<Project>();
			var result = rep.Get();
			return result;
		}

		public IEnumerable<TaskViewModel> GetTasks()
		{
			var rep = new BaseRepository<Task>();
			var tasks = rep.Get();
			var result = new List<TaskViewModel>();
			foreach (var item in tasks)
			{
				result.Add(new TaskViewModel()
				{
					Id = item.ID,
					Name = item.Name,
					Description = item.Description,
					DueDate = item.DueDate.Date.ToString(),
					StartDate = item.CreationDate.Date.ToString(),
					Project_Id = item.Project.Id,
					User_Id = item.User.Id
				});
			}
			return result;
		}

		public IEnumerable<User> GetUsers()
		{
			var rep = new BaseRepository<User>();
			var result = rep.Get();

			return result;
		}

		public IEnumerable<MileStoneViewModel> GetMilestones()
		{
			var rep = new BaseRepository<Milestone>();
			var ms = rep.Get();
			var result = new List<MileStoneViewModel>();
			foreach (var item in ms)
			{
				result.Add(new MileStoneViewModel()
				{
					Id = item.Id,
					Name = item.Name,
					EndDate = item.EndDate.Date.ToString(),
					StartDate = item.StartDate.Date.ToString(),
					User_Id = item.User.Id
				});
			}
			return result;
		}

		public IEnumerable<Role> GetRoles()
		{
			var rep = new BaseRepository<Role>();
			var result = rep.Get();
			return result;
		}

		public IEnumerable<UserRoleViewModel> GetUserRoles()
		{
			var rep = new BaseRepository<UserRole>();
			var ur = rep.Get();
			var result = new List<UserRoleViewModel>();
			foreach (var item in ur)
			{
				result.Add(new UserRoleViewModel()
				{
					Id = item.Id,
					Project_Id = item.Project.Id,
					Role_Id = item.Role.Id,
					User_Id = item.User.Id
				});
			}
			return result;
		}

		public IEnumerable<MileStoneTaskViewModel> GetMilestoneTask()
		{
			var rep = new BaseRepository<MilestoneTask>();
			var ms = rep.Get();
			var result = new List<MileStoneTaskViewModel>();
			foreach (var item in ms)
			{
				result.Add(new MileStoneTaskViewModel()
				{
					Id = item.Id,
					Milestone_Id = item.Milestone.Id,
					Task_Id = item.Task.ID
				});
			}
			return result;
		}
	}
}
