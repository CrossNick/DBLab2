using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Busines
{
	public class QueryLogic
	{
		Querys _query;
		public QueryLogic()
		{
			_query = new Querys();
		}
		public IEnumerable<Query1Model> SimpleQuery1()
		{
			var result = _query.Query1();
			return result;
		}

		public IEnumerable<AgregateQuery1Model> AgregateQuery1()
		{
			var result = _query.AgregateQuery1();
			return result;
		}

		public IEnumerable<AgregateNestedQuery1Model> NestedAgregateQuery1()
		{
			var result = _query.NestedAgregateQuery1();
			return result;
		}

		public IEnumerable<FunctionModel> FunctionQuery(string projectName)
		{
			var result = _query.FunctionQuery(projectName);
			return result;
		}
	}
}
