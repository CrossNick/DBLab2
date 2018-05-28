using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBLab2.Busines;
using DBLab2.Models;

namespace DBLab2.UI.Controllers
{
	public class HomeController : Controller
	{
		GetLogic getLogic;
		QueryLogic queryLogic;

		public HomeController()
		{
			getLogic = new GetLogic();
			queryLogic = new QueryLogic();
		}

		public ActionResult Index()
		{
			return View();
		}
		
		public JsonResult GetProjects()
		{
			var result = getLogic.GetProjects();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetTasks()
		{
			var result = getLogic.GetTasks();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetUsers()
		{
			var result = getLogic.GetUsers();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetMilestones()
		{
			var result = getLogic.GetMilestones();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetMilestoneTasks()
		{
			var result = getLogic.GetMilestoneTask();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetRoles()
		{
			var result = getLogic.GetRoles();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetUserRoles()
		{
			var result = getLogic.GetUserRoles();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}


		public JsonResult GetSimpleQuery1()
		{
			var result = queryLogic.SimpleQuery1();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetSimpleQuery2(string userName)
		{
			var result = queryLogic.SimpleQuery2(userName);
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetSimpleQuery3(string projectName)
		{
			var result = queryLogic.SimpleQuery3(projectName);
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetSimpleQuery4(string userName)
		{
			var query = queryLogic.SimpleQuery4(userName);
			var result = new List<Query4ViewModel>();
			foreach (var item in query)
			{
				result.Add(new Query4ViewModel()
				{
					TaskName = item.TaskName,
					MlName = item.MlName,
					StartDate = item.StartDate.ToString(),
					EndDate = item.EndDate.ToString()
				});
			}
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetSimpleQuery5(string mlName)
		{
			var query = queryLogic.SimpleQuery5(mlName);
			var result = new List<Query5ViewModel>();
			foreach (var item in query)
			{
				result.Add(new Query5ViewModel()
				{
					TaskName = item.TaskName,
					Description = item.Description,
					CreationDate = item.CreationDate.ToString(),
					DueDate = item.DueDate.ToString(),
					ProjectName = item.ProjectName
				});
			}
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetAgregate1()
		{
			var result = queryLogic.AgregateQuery1();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetNested1()
		{
			var result = queryLogic.NestedAgregateQuery1();
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetNested2(string projectName)
		{
			var result = queryLogic.NestedQuery2(projectName);
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetFunction(string projectName)
		{
			var result = queryLogic.FunctionQuery(projectName);
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

		public JsonResult GetProcedure(string projectName)
		{
			var result = queryLogic.ProcedureQuery(projectName);
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

	}
}