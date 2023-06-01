using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MvcFirstCodeEntity.Models.Classes;

namespace MvcFirstCodeEntity.Controllers
{
    public class DefaultController : Controller
    {
		Context c = new Context();
		// GET: Default
		public ActionResult Index()
        {
            var data = c.YETENEKLERS.ToList();
            return View(data);
        }
        
    }
}