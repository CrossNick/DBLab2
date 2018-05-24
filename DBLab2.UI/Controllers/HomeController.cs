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

		public JsonResult GetFunction(string projectName)
		{
			var result = queryLogic.FunctionQuery(projectName);
			var res = Json(result, JsonRequestBehavior.AllowGet);
			return res;
		}

	}
}