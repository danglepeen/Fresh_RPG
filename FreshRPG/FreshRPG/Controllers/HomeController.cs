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
using ViewModels;

namespace FreshRPG.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var model = new HomeViewModel();
			return View(model);
		}

		[HttpPost]
		public ActionResult IndexPost(HomeViewModel viewModel)
		{
			var characterBag = PropertyBagFactory.CreateBag(BagType.Character) as CharacterPropertyBag;
			characterBag.Name = viewModel.Name;
			characterBag.Health = 100;
			characterBag.Level = 1;
			characterBag.Alignment = Alignment.Good;
			
			var model = new BeginViewModel();
			model.Player = new Character(characterBag);
			model.Player.XPToNextLevel = model.Player.CalculateToNextLevel();
			
			model.Player.Weapon = new Weapon();
			var weapon = model.Player.Weapon;
			weapon.Name = "Home Run Bat";
			weapon.ItemEffect = ItemEffect.Harmful;
			weapon.ItemAvailability = ItemAvailability.Free;
			weapon.DesignatedFor = Designation.CharacterOne;
			weapon.Description = "Made of sturdy ash. Someone's name is scribbled on it.";
			weapon.AttackStat = 22;
			weapon.ResaleValue = 35.00M;
			return View("Begin", model);
		}

		public ActionResult Begin(BeginViewModel model)
		{
			return View(model);
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