using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea4.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

	   [HttpPost]
		public ActionResult total(int value1, int value2, String calc)
		{

			int total = 0;

			switch (calc)
			{
				case "+":
					total = value1 + value2;
					break;
				case "-":
					total = value1 - value2;
					break;
				case "*":
					total = value1 * value2;
					break;
				case "/":
					total = value1 / value2;
					break;
				default:
					total = 0;
					break;
					lkokllkok


			}

			
			return View("Resultado:" + total);
			
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}