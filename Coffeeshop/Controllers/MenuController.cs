using Coffeeshop.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Coffeeshop.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        CafeModel cf = new CafeModel();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(string name, int money)
        {
            MENU menu = new MENU();
            menu.name = name;
            menu.money = money;
            cf.MENUS.Add(menu);
            cf.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var menu = cf.MENUS.Find(id);
            return View(menu);
        }
        public ActionResult Delete(int? id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MENU menu = cf.MENUS.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            cf.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult cfDelete(int id)
        {
            MENU menu = new MENU();
            cf.MENUS.Find(id);
            cf.MENUS.Remove(menu);
            cf.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult edit(int? id)
        {
            if(id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MENU menu = cf.MENUS.Find(id);
            return View(menu);
        }
        public ActionResult Edit(int id, string name, int money)
        {
            var menu = cf.MENUS.Find(id);
            menu.name = name;
            menu.money = money;
            cf.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}