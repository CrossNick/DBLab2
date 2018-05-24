using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab2.Models
{
	public class MilestoneTask
	{
		public int Id { get; set; }
		public virtual Milestone Milestone { get; set; }
		public virtual Task Task { get; set; }
	}
}
