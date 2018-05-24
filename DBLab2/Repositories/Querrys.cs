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

		public IEnumerable<FunctionModel> FunctionQuery(string projectName)
		{
			System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Name", projectName);
			var result = _context.Database.SqlQuery<FunctionModel>("SELECT dbo.GetProjectUserCount(@Name) AS Num", param).ToList();
			return result;
		}
	}
}
