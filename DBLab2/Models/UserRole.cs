using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Models
{
	public class UserRole
	{
		public int Id { get; set; }
		public virtual Role Role { get; set; }
		public virtual User User { get; set; }
		public virtual Project Project { get; set; }
	}
}
