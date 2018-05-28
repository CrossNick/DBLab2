using DBLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLab2
{
	public class Querys
	{
		BTDbContext _context;
		public Querys()
		{
			_context = new BTDbContext();
		}

		//Select all admins
		public IEnumerable<Query1Model> Query1()
		{
			var result = _context.Database.SqlQuery<Query1Model>("SELECT [User].UserName AS UserName, " +
				"[Project].Name AS ProjectName FROM [User], [Project], [Role], [UserRole] WHERE [User].Id = [UserRole].User_Id " +
				"AND [Project].Id =  [UserRole].Project_Id AND [UserRole].Role_Id = [Role].Id AND [Role].Name = 'Admin'").ToList();
			return result;
		}

		//All tasks from user
		public IEnumerable<Query2Model> Query2(string userName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", userName);
			var result = _context.Database.SqlQuery<Query2Model>("SELECT [Task].Name as TaskName, [Task].Description as Description, " +
				"[Project].Name as ProjectName FROM [Task], [User],[Project] " +
			"WHERE [Task].User_Id = [User].Id and [User].UserName = @Name and [Task].Project_Id = [Project].Id", param).ToList();
			return result;
		}

		//All tasks from project
		public IEnumerable<Query3Model> Query3(string projectName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", projectName);
			var result = _context.Database.SqlQuery<Query3Model>("SELECT [Task].Name as TaskName, [Task].Description as Description, " +
				"[User].UserName as UserName FROM [Task], [User],[Project] " +
			"WHERE [Project].Name = @Name and [Project].Id = [Task].Project_Id and [Task].User_Id = [User].Id", param).ToList();
			return result;
		}

		//Task belong to Milestone of user
		public IEnumerable<Query4Model> Query4(string userName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", userName);
			var result = _context.Database.SqlQuery<Query4Model>("SELECT [Task].Name as TaskName, [Milestone].Name as MlName," +
				" [Milestone].StartDate as StartDate, [Milestone].EndDate as EndDate FROM [User], [Task], [Milestone], [MilestoneTask] " +
				" WHERE [Milestone].Id = [MilestoneTask].Milestone_Id and [Task].Id = [MilestoneTask].Task_ID " +
				" and [Task].User_Id = [User].Id and [User].UserName = @Name", param).ToList();
			return result;
		}

		//All tasks for gieven milestone
		public IEnumerable<Query5Model> Query5(string mlName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", mlName);
			var result = _context.Database.SqlQuery<Query5Model>("SELECT [Task].Name as TaskName, [Task].Description as Description," +
				" [Task].CreationDate as CreationDate, [Task].DueDate as DueDate,  [Project].Name as ProjectName " +
				"FROM [Task], [Milestone], [MilestoneTask], [Project] WHERE [Milestone].Name = @Name and " +
				"[Milestone].Id = [MilestoneTask].Milestone_Id and [Task].Id = [MilestoneTask].Task_ID and " +
				"[Task].Project_Id = [Project].Id", param).ToList();
			return result;
		}

		public IEnumerable<AgregateQuery1Model> AgregateQuery1()
		{
			var result = _context.Database.SqlQuery<AgregateQuery1Model>("SELECT [User].UserName as UserName, COUNT([Task].Id) as TaskCount From [User], [Task] " +
				"Where Task.User_Id = [User].Id Group By [User].UserName").ToList();
			return result;
		}

		public IEnumerable<AgregateNestedQuery1Model> NestedAgregateQuery1()
		{
			var result = _context.Database.SqlQuery<AgregateNestedQuery1Model>("SELECT AVG(taskCount) as Average FROM (SELECT  COUNT([Task].Id) as taskCount FROM [Task], [User] " +
				"WHERE [User].Id = [Task].User_Id GROUP BY [User].UserName) MyTable").ToList();
			return result;
		}

		public IEnumerable<NestedQuery2Model> NestedQuery2(string projectName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", projectName);
			var result = _context.Database.SqlQuery<NestedQuery2Model>("SELECT [Nested].UserName as UserName, [Nested].RoleName as RoleName FROM [Project]," +
				"(SELECT [UserRole].Project_Id as ProjectId, [User].UserName as UserName, [Role].Name as RoleName FROM [UserRole],  [User], [Role] " +
			"WHERE [UserRole].User_Id = [User].Id AND [UserRole].Role_Id = [Role].Id) Nested WHERE [Project].Name = @Name AND [Project].Id = [Nested].ProjectId", param).ToList();
			return result;
		}

		public IEnumerable<FunctionModel> FunctionQuery(string projectName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", projectName);
			var result = _context.Database.SqlQuery<FunctionModel>("SELECT dbo.GetProjectUserCount(@Name) AS Num", param).ToList();
			return result;
		}

		public IEnumerable<ProcedureModel> ProcedureQuery(string projectName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", projectName);
			var result = _context.Database.SqlQuery<ProcedureModel>("UsersInProject @Name", param).ToList();
			return result;
		}
	}
}
