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
		public IEnumerable<Query2Model> SimpleQuery2(string userName)
		{
			var result = _query.Query2(userName);
			return result;
		}

		public IEnumerable<Query3Model> SimpleQuery3(string projectName)
		{
			var result = _query.Query3(projectName);
			return result;
		}

		public IEnumerable<Query4Model> SimpleQuery4(string projectName)
		{
			var result = _query.Query4(projectName);
			return result;
		}

		public IEnumerable<Query5Model> SimpleQuery5(string projectName)
		{
			var result = _query.Query5(projectName);
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

		public IEnumerable<NestedQuery2Model> NestedQuery2(string projectName)
		{
			var result = _query.NestedQuery2(projectName);
			return result;
		}

		public IEnumerable<FunctionModel> FunctionQuery(string projectName)
		{
			var result = _query.FunctionQuery(projectName);
			return result;
		}

		public IEnumerable<ProcedureModel> ProcedureQuery(string projectName)
		{
			var result = _query.ProcedureQuery(projectName);
			return result;
		}
	}
}
