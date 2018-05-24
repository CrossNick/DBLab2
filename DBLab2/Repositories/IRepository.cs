using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Repositories
{
	interface IRepository<T> where T : class
	{
		IEnumerable<T> Get();
		T Get(int Id);
		void Create(T Entity);
		void Update(T Entity);
		void Delete(int Id);
	}
}
