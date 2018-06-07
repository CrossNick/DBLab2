using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Repositories
{
	public class BaseRepository<T>  : IRepository<T> where T : class
	{
		BTDbContext _context;
		DbSet<T> table;

		public BaseRepository()
		{
			_context = new BTDbContext();
			table = _context.Set<T>();
        }
		public void Create(T Entity)
		{
			table.Add(Entity);
			_context.SaveChanges();
        }

		public void Delete(int Id)
		{
			var ent = table.Find(Id);
			if(ent!= null)
			{
		
				table.Remove(ent);
				_context.SaveChanges();
				table = _context.Set<T>();
			}
			
		}

		public IEnumerable<T> Get()
		{
			return table;
		}

		public T Get(int Id)
		{
			var ent = table.Find(Id);

			return ent;
			
        }

		public void Update(T Entity)
		{
			table.Attach(Entity);
            _context.Entry(Entity).State = EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
