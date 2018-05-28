using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2
{
	public class Query1Model{
		public string UserName { get; set; }
		public string ProjectName { get; set; }
	}

	public class Query2Model
	{
		public string TaskName { get; set; }
		public string Description { get; set; }
		public string ProjectName { get; set; }
	}

	public class Query3Model
	{
		public string TaskName { get; set; }
		public string Description { get; set; }
		public string UserName { get; set; }
	}

	public class Query4Model
	{
		public string TaskName { get; set; }
		public string MlName { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
	public class Query4ViewModel
	{
		public string TaskName { get; set; }
		public string MlName { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
	}


	public class Query5Model
	{
		public string TaskName { get; set; }
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime DueDate { get; set; }
		public string ProjectName { get; set; }
	}

	public class Query5ViewModel
	{
		public string TaskName { get; set; }
		public string Description { get; set; }
		public string CreationDate { get; set; }
		public string DueDate { get; set; }
		public string ProjectName { get; set; }
	}


	public class AgregateQuery1Model
	{
		public string UserName { get; set; }
		public int TaskCount { get; set; }
	}

	public class AgregateNestedQuery1Model
	{
		public int Average { get; set; }
	}
	public class NestedQuery2Model
	{
		public string UserName { get; set; }
		public string RoleName { get; set; }
	}
	public class FunctionModel
	{
		public int Num { get; set; }
	}
	public class ProcedureModel
	{
		public string UserName { get; set; }
		public string RoleName { get; set; }
	}


}
