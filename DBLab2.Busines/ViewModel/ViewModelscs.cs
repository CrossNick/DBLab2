using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Busines
{
	public class TaskViewModel
	{
		public int Id;
		public string Name;
		public string Description;
		public string StartDate;
		public string DueDate;
		public int Project_Id;
		public int User_Id;
	}

	public class MileStoneViewModel
	{
		public int Id;
		public string Name;
		public string StartDate;
		public string EndDate;
		public int User_Id;
	}


	public class MileStoneTaskViewModel
	{
		public int Id;
		public int Milestone_Id;
		public int Task_Id;
	}

	public class UserRoleViewModel
	{
		public int Id;
		public int Role_Id;
		public int Project_Id;
		public int User_Id;
	}
}
