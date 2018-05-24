using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Models
{
	public class Task
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime DueDate { get; set; }
		public virtual User User { get; set; }
		public virtual Project Project { get; set; }
	}
}
