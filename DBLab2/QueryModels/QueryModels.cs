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

	public class AgregateQuery1Model
	{
		public string UserName { get; set; }
		public int TaskCount { get; set; }
	}

	public class AgregateNestedQuery1Model
	{
		public int Average { get; set; }
	}

	public class FunctionModel
	{
		public int Num { get; set; }
	}

}
