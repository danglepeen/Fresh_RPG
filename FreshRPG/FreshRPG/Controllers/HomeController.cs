using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Enums;
using Models;
using Interfaces;
using PropertyBags;
using System.Linq.Expressions;

namespace FreshRPG.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Begin()
		{
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}




		public TProp Get<TModel, TProp>(TModel model, Expression<Func<TModel, TProp>> expression) where TModel : IPropertyBag
		{
			var value = expression.Compile()(model);
			return value;
		}
	}
}