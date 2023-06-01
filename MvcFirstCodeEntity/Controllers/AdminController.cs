using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MvcFirstCodeEntity.Models.Classes;
using System.Data.Entity.Migrations;

namespace MvcFirstCodeEntity.Controllers
{
    public class AdminController : Controller
    {
		Context context = new Context();
		// GET: Admin
		public ActionResult Index()
        {
            var data = context.YETENEKLERS.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(YETENEKLER y)
        {
            context.YETENEKLERS.Add(y);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
		public ActionResult YetenekSil(byte id)
		{
			var ytnk = context.YETENEKLERS.Find(id);
			context.YETENEKLERS.Remove(ytnk);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
        [HttpGet]
		public ActionResult YetenekGuncelle(byte id)
		{
            var deger = context.YETENEKLERS.Find(id);
			return View("YetenekGuncelle",deger);
		}
        [HttpPost]
		public ActionResult YetenekGuncelle(YETENEKLER y)
        {
            var ytnk = context.YETENEKLERS.Find(y.ID);
            ytnk.ACIKLAMA = y.ACIKLAMA;
            ytnk.DEGER = y.DEGER;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}