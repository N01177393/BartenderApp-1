using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class BartenderController : Controller
    {
        private DrinkDbContext db = new DrinkDbContext();
        public static Queue<Drink> OrderQueue = new Queue<Drink>();

        //Homepage
        public ActionResult Home()
        {
            return View();
        }
        
        //View drink menu
        public ActionResult Menu()
        {
            return View(db.Drinks.ToList());
        }

        //View details of each drink
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drink drink = db.Drinks.Find(id);
            if (drink == null)
            {
                return HttpNotFound();
            }
            return View(drink);
        }

        //Add drink order to queue
        public ActionResult Thanks(int? id)
        {
            //Add drink to queue
            Drink drink = db.Drinks.Find(id);
            OrderQueue.Enqueue(drink);
            return View();
        }

        //View order queue
        public ActionResult DrinkQueue()
        {
            return View(OrderQueue);
        }

        //Set order for server pick up and remove from queue 
        public ActionResult Remove()
        {
            OrderQueue.Dequeue();
            return RedirectToAction("DrinkQueue");
        }
    }
}
